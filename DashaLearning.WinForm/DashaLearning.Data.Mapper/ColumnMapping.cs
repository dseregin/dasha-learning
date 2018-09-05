using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace DashaLearning.Data.Mapper
{
    public class ColumnMapping
    {
        private static readonly ColumnMappingConfiguration Config = new ColumnMappingConfiguration();

        public static void Initialize(Action<ColumnMappingConfiguration> configure)
        {
            configure?.Invoke(Config);
        }

        public static ColumnMapping<T> GetFor<T>()
        {
            return Config.GetMapping<T>();
        }
    }

    public class ColumnMapping<T> : ColumnMapping
    {
        protected PropertyMap Map(Expression<Func<T, object>> expression)
        {
            var info = (PropertyInfo)GetMemberInfo(expression);
            var propertyName = info.Name;
            var mapping = new PropertyMap(propertyName);
            Mappings[propertyName] = mapping;
            return mapping;
        }

        protected void HasTableName(string tableName)
        {
            TableName = tableName;
        }

        private Dictionary<string, PropertyMap> Mappings { get; } = new Dictionary<string, PropertyMap>();

        public string TableName { get; private set; }

        private static MemberInfo GetMemberInfo(LambdaExpression lambda)
        {
            Expression expr = lambda;
            while (true)
            {
                switch (expr.NodeType)
                {
                    case ExpressionType.Lambda:
                        expr = ((LambdaExpression)expr).Body;
                        break;

                    case ExpressionType.Convert:
                        expr = ((UnaryExpression)expr).Operand;
                        break;

                    case ExpressionType.MemberAccess:
                        var memberExpression = (MemberExpression)expr;
                        var baseMember = memberExpression.Member;

                        // Make sure we get the property from the derived type.
                        var paramType = lambda.Parameters[0].Type;
                        var memberInfo = paramType.GetMember(baseMember.Name)[0];
                        return memberInfo;

                    default:
                        return null;
                }
            }
        }

        public string ForAllProps(params Expression<Func<T, object>>[] except)
        {
            return ForAllProps(string.Empty, except);
        }

        public string ForAllProps(string tableAlias, params Expression<Func<T, object>>[] except)
        {
            var alias = !string.IsNullOrWhiteSpace(tableAlias) ? tableAlias + "." : string.Empty;

            return string.Join(", ",
                Mappings.Values.Where(m => !except.Select(ColumnName).Contains(m.ColumnName))
                    .Select(m => $"{m.ColumnFunction}({alias}{m.ColumnName}) as {m.PropertyName}"));
        }

        public string ForProp(Expression<Func<T, object>> expression, string tableName = "")
        {
            var info = (PropertyInfo)GetMemberInfo(expression);
            var propertyName = info.Name;
            var propertyMap = Mappings[propertyName];
            return $"{(string.IsNullOrEmpty(tableName) ? "" : $"{tableName}.")}{propertyMap.ColumnName} as {propertyMap.PropertyName}";
        }

        public string ColumnName(Expression<Func<T, object>> expression)
        {
            var info = (PropertyInfo)GetMemberInfo(expression);
            var propertyName = info.Name;
            var propertyMap = Mappings[propertyName];
            return propertyMap.ColumnName;
        }

        public string PropertyName(Expression<Func<T, object>> expression)
        {
            var info = (PropertyInfo)GetMemberInfo(expression);
            var propertyName = info.Name;
            return propertyName;
        }

        public string AllColumns(params Expression<Func<T, object>>[] except)
        {
            return AllColumns(string.Empty, except);
        }

        public string AllColumns(string tableAlias = null, params Expression<Func<T, object>>[] except)
        {
            var alias = !string.IsNullOrWhiteSpace(tableAlias) ? tableAlias + "." : string.Empty;

            return string.Join(", ",
                Mappings.Values.Where(m => !except.Select(ColumnName).Contains(m.ColumnName))
                    .Select(m => $"{alias}{m.ColumnName}"));
        }

        public string AllProperties(params Expression<Func<T, object>>[] except)
        {
            return AllProperties(string.Empty, except);
        }

        public string AllProperties(string tableAlias = null, params Expression<Func<T, object>>[] except)
        {
            var alias = !string.IsNullOrWhiteSpace(tableAlias) ? tableAlias + "." : string.Empty;

            return string.Join(", ",
                Mappings.Values.Where(m => !except.Select(PropertyName).Contains(m.PropertyName))
                    .Select(m => $"{alias}{m.PropertyName}"));
        }

        public string AllPropertiesParams(params Expression<Func<T, object>>[] except)
        {
            return string.Join(", ",
                Mappings.Values.Where(m => !except.Select(PropertyName).Contains(m.PropertyName))
                    .Select(m => $"{m.ColumnFunction}(@{m.PropertyName})"));
        }

        public string AllPropsValues(string tableAlias, params Expression<Func<T, object>>[] except)
        {
            return string.Join(", ",
                Mappings.Values.Where(m => !except.Select(ColumnName).Contains(m.ColumnName))
                    .Select(m => $"@{m.PropertyName}"));
        }

        public bool HasPropertyInDb(string propertyName)
        {
            return Mappings.ContainsKey(propertyName);
        }
    }

    public class ColumnMappingConfiguration
    {
        private readonly Dictionary<Type, ColumnMapping> _mappings = new Dictionary<Type, ColumnMapping>();

        public void AddMap<T>(ColumnMapping<T> mapping)
        {
            _mappings[typeof(T)] = mapping;
        }

        public ColumnMapping<T> GetMapping<T>()
        {
            return (ColumnMapping<T>)_mappings[typeof(T)];
        }
    }

    public class PropertyMap
    {
        public PropertyMap(string propertyName)
        {
            PropertyName = propertyName;
        }

        public string ColumnName { get; private set; }

        public string PropertyName { get; private set; }

        public string ColumnFunction { get; private set; }

        public void ToColumn(string columnName, bool quot = true, string function = "")
        {
            ColumnName = quot ? $"\"{columnName}\"" : $"{columnName}";
            ColumnFunction = function;
        }

    }
}
