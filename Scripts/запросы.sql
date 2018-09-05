-- user с логином login3
select * from users where login = 'login3'

-- юзеры, которые в сети
select * from users where is_online = true

-- сколько всего юзеров
select count(*) from users

-- сколько всего узеров в сети
select count(*) from users where is_online = true

-- юзеры и их персы
select * from users u
join persons p on p.user_id = u.id

-- юзеры персов, которые в сети (условие в where)
select * from users u
join persons p on p.user_id = u.id
where u.is_online = true

-- юзеры персов, которые в сети (условие в join)
select * from users u
join persons p on p.user_id = u.id and u.is_online = true

-- все юзеры (даже у которых еще нет персов)
select * from users u
left join persons p on p.user_id = u.id

-- логины юзеров с именами и классами персов с алиасами
select u.login "Логин", p.name "Имя персонажа", c.name "Класс" from users u
join persons p on p.user_id = u.id
join classes c on p.class_id = c.id

-- сколько персов у каждого юзера
select u.login, count(p.id) from users u
left join persons p on p.user_id = u.id
group by u.login
order by u.login

-- персы с классами, характеристиками и скилами, остортированные по уровням и классам
select p.name as "Имя персонажа", c.name as "Класс", st.intellect_value as "Интеллект", st.agility_value "Ловкость", st.strenght_value "Сила",  pc.max_hp as "Жизнь", pc.max_mana as "Мана", pc.level as "Уровень", sk.name "Скилл", ps.power_value "Урон"
from persons p
join classes c on p.class_id = c.id
join stats st on st.person_id = p.id
join person_characteristics pc on pc.person_id = p.id
join persons_skills ps on ps.person_id = p.id
join skills sk on sk.id = ps.skill_id
order by pc.level, c.name