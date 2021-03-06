﻿insert into types values
('{8752D1A6-A7A5-4D60-9F04-C49F3DA5193B}','Оружие'),
('{001B5152-F0FB-4445-86A9-F5FA0BBC0F2B}','Доспех'),
('{1ED86003-3168-4D0C-9F87-6B8EE449941F}','Штаны'),
('{D8909F29-1F65-4099-81A9-F053161BBFDF}','Обувь'),
('{934E23EB-E5AA-4728-B5F5-E49D13D3BEE5}','Зелье'),
('{F9AA5BBD-CE32-4224-A462-C69A66788E48}','Самоцвет'),
('{0278E164-7B7A-4C7C-BF72-EB0A53828DA6}','что-то еще');

insert into users values
('{978963E4-6C68-450B-9227-15EF6AD3CE45}','login1','password1',true,'2018-01-01 00:00:00'),
('{99FABD85-A786-4A4E-AE84-DFA71B005C56}','login2','password2',false,'2018-01-01 00:00:00'),
('{F7EA2706-C718-4AA0-AACA-0526FCA56B9F}','login3','password3',true,'2018-01-01 00:00:00'),
('{7218A60E-77D1-4971-A7FD-487629425F8E}','login4','password4',false,'2018-01-01 00:00:00'),
('{374EF70A-18AE-49D3-BDF1-C788ADECC9CF}','login5','password5',true,'2018-01-01 00:00:00'),
('{B8AC5585-BC2D-43BC-AF64-2EBD61B994F7}','login6','password6',false,'2018-01-01 00:00:00');

insert into classes values
('{A46BFAA1-EDA9-4474-A833-B24B9F80125E}','Чародей','Описание чародея'),
('{57784894-4574-4996-8F88-EFB246E4B914}','Колдун','Описание колдуна'),
('{F585E357-B82B-47CC-91B4-55A4BDF63A09}','Охотник','Описание охотника'),
('{FA4F7013-3FC3-4A56-BE7E-E7B5FCF8FC0D}','Монах','Описание монаха'),
('{1A70BF3C-C270-4564-8302-BD8FC5BD454B}','Крестоносец','Описание крестоносца'),
('{66D8367C-0950-4242-AD4D-EC69F4CF76BF}','Варвар','Описание варвара');

insert into persons values
('{5BE36B8B-E86A-417F-B455-3857A11F3AB8}','{978963E4-6C68-450B-9227-15EF6AD3CE45}','name1',true,'{A46BFAA1-EDA9-4474-A833-B24B9F80125E}'),
('{9C963EFF-BBEB-407F-9080-E94F142B66B2}','{978963E4-6C68-450B-9227-15EF6AD3CE45}','name2',true,'{57784894-4574-4996-8F88-EFB246E4B914}'),
('{6C9CFBE1-2C0D-42E5-BC9D-EB3D9BBCBEC1}','{99FABD85-A786-4A4E-AE84-DFA71B005C56}','name3',true,'{F585E357-B82B-47CC-91B4-55A4BDF63A09}'),
('{D91322B1-2892-45E5-ADD0-019F63E87FBD}','{F7EA2706-C718-4AA0-AACA-0526FCA56B9F}','name4',true,'{A46BFAA1-EDA9-4474-A833-B24B9F80125E}'),
('{53675DEE-48D3-42EA-A1CE-45B6DCBC3B46}','{F7EA2706-C718-4AA0-AACA-0526FCA56B9F}','name5',true,'{1A70BF3C-C270-4564-8302-BD8FC5BD454B}'),
('{31FF39E0-1F57-446A-A7D6-7D3427569BB7}','{F7EA2706-C718-4AA0-AACA-0526FCA56B9F}','name6',true,'{66D8367C-0950-4242-AD4D-EC69F4CF76BF}'),
('{A620DF4F-109E-4B8C-B337-662E41DE7FCC}','{7218A60E-77D1-4971-A7FD-487629425F8E}','name7',true,'{57784894-4574-4996-8F88-EFB246E4B914}'),
('{338E9AB4-96A6-4D2D-AB24-14FD19BDA0C6}','{7218A60E-77D1-4971-A7FD-487629425F8E}','name8',true,'{FA4F7013-3FC3-4A56-BE7E-E7B5FCF8FC0D}'),
('{7D6FA3EC-3A08-4F2E-A9C5-EE3526AFCF51}','{374EF70A-18AE-49D3-BDF1-C788ADECC9CF}','name9',true,'{A46BFAA1-EDA9-4474-A833-B24B9F80125E}'),
('{2A77ADCE-C5D5-428D-A1B4-65A20FCDFD76}','{374EF70A-18AE-49D3-BDF1-C788ADECC9CF}','name10',true,'{57784894-4574-4996-8F88-EFB246E4B914}');

insert into stats values
('{6CABAD53-0D00-423E-BBE0-C37372ADC563}',50,15,10,'{5BE36B8B-E86A-417F-B455-3857A11F3AB8}'),
('{194B144D-B69C-4802-BD13-E8CB4AF44FDD}',0,150,80,'{9C963EFF-BBEB-407F-9080-E94F142B66B2}'),
('{FF2C9B28-1105-4B83-B2E2-D034AC35F0EE}',90,350,100,'{6C9CFBE1-2C0D-42E5-BC9D-EB3D9BBCBEC1}'),
('{2CC4A946-99A4-4923-9AC6-52D5447D9331}',8,13,6,'{D91322B1-2892-45E5-ADD0-019F63E87FBD}'),
('{E0711288-CBCD-430A-BEED-4643254F504B}',40,40,10,'{53675DEE-48D3-42EA-A1CE-45B6DCBC3B46}'),
('{BA2FA5D7-29F5-4D54-BDC6-7BA5472DDFC8}',950,150,510,'{31FF39E0-1F57-446A-A7D6-7D3427569BB7}'),
('{846C3C76-1BFD-4412-9A44-0FD56306EB8D}',60,0,5,'{A620DF4F-109E-4B8C-B337-662E41DE7FCC}'),
('{43DC1FB2-6842-4137-B543-3440CC7082BA}',5,55,65,'{338E9AB4-96A6-4D2D-AB24-14FD19BDA0C6}'),
('{95340885-F773-4E56-810E-08E5789A2199}',70,150,100,'{7D6FA3EC-3A08-4F2E-A9C5-EE3526AFCF51}'),
('{8FB0DD96-754C-49D4-B5B7-E11BBF49AEA4}',0,0,10,'{2A77ADCE-C5D5-428D-A1B4-65A20FCDFD76}');

insert into skills values
('{4A466061-C6B2-4F25-B34C-2F3693B7E3FE}','умение чародея 1','описание умения чародея 1'),
('{6E6DD40E-F177-4CCF-9602-72211C9209D6}','умение чародея 2','описание умения чародея 2'),
('{2851E425-6FC6-4E22-BEF7-1B6D6385119D}','умение колдуна 1','описание умения колдуна 1'),
('{E3D5D9F4-2619-4C7B-BA53-4808A766E688}','умение колдуна 2','описание умения колдуна 2'),
('{4B5F5ADD-A309-4EC5-924F-F60B85CCE030}','умение охотника 1','описание умения охотника 1'),
('{B855F5B9-7E49-420C-BB4E-D1E11D220363}','умение охотника 2','описание умения охотника 2'),
('{76A25BD4-38D0-40C7-9E1E-43C4CAE91ACF}','умение монаха 1','описание умения монаха 1'),
('{0D270274-2C55-41BB-8EDA-F5F2CE46CC06}','умение монаха 2','описание умения монаха 2'),
('{35C40BD2-400C-4903-B8DD-7C5B632D9E94}','умение крестоносца 1','описание умения крестоносца 1'),
('{402836CA-89D6-4C31-A6B6-CAD6DA8C75FE}','умение крестоносца 2','описание умения крестоносца 2'),
('{4C51EA08-DF91-4635-8F52-47CC99DE4DFA}','умение варвара 1','описание умения варвара 1'),
('{E2667B01-91E9-477B-9E8C-049F4D5920FF}','умение варвара 2','описание умения варвара 2');

insert into persons_skills values
('{8CB56408-29AC-4A7D-A556-D251503BA689}','{5BE36B8B-E86A-417F-B455-3857A11F3AB8}','{4A466061-C6B2-4F25-B34C-2F3693B7E3FE}',10),
('{973C0603-E495-4B30-9516-91965C7776DD}','{5BE36B8B-E86A-417F-B455-3857A11F3AB8}','{6E6DD40E-F177-4CCF-9602-72211C9209D6}',15),
('{CBC02F42-7D5B-4B61-91CA-C7362AC0E946}','{9C963EFF-BBEB-407F-9080-E94F142B66B2}','{2851E425-6FC6-4E22-BEF7-1B6D6385119D}',5),
('{553EED96-12FF-49E6-901B-F410E0FA6A8C}','{9C963EFF-BBEB-407F-9080-E94F142B66B2}','{E3D5D9F4-2619-4C7B-BA53-4808A766E688}',20),
('{B47DF87D-BE3D-47FE-BCE9-FC1148CD393F}','{6C9CFBE1-2C0D-42E5-BC9D-EB3D9BBCBEC1}','{4B5F5ADD-A309-4EC5-924F-F60B85CCE030}',15),
('{1E8AEE35-3F25-4B64-B1D6-712040ED5D1B}','{6C9CFBE1-2C0D-42E5-BC9D-EB3D9BBCBEC1}','{B855F5B9-7E49-420C-BB4E-D1E11D220363}',15),
('{CC3EB7B8-FCF0-4C43-9859-8E50EA3BB277}','{D91322B1-2892-45E5-ADD0-019F63E87FBD}','{4A466061-C6B2-4F25-B34C-2F3693B7E3FE}',5),
('{6DB840D0-18CA-465F-8F29-99BED50C9B07}','{D91322B1-2892-45E5-ADD0-019F63E87FBD}','{6E6DD40E-F177-4CCF-9602-72211C9209D6}',25),
('{E6347B21-CED4-46C0-9B25-F30AB088E0C2}','{53675DEE-48D3-42EA-A1CE-45B6DCBC3B46}','{35C40BD2-400C-4903-B8DD-7C5B632D9E94}',20),
('{B592BBE1-462C-4373-B3A4-DBD1B0004765}','{53675DEE-48D3-42EA-A1CE-45B6DCBC3B46}','{402836CA-89D6-4C31-A6B6-CAD6DA8C75FE}',25),
('{73D5513D-806F-4388-AC2D-A219BB1BDFB9}','{31FF39E0-1F57-446A-A7D6-7D3427569BB7}','{4C51EA08-DF91-4635-8F52-47CC99DE4DFA}',50),
('{29FEA1BB-1663-4B3A-B5EB-0CFA4EEA5868}','{31FF39E0-1F57-446A-A7D6-7D3427569BB7}','{E2667B01-91E9-477B-9E8C-049F4D5920FF}',30),
('{D7686116-515B-48EC-BF52-E5FD49BA09F0}','{A620DF4F-109E-4B8C-B337-662E41DE7FCC}','{2851E425-6FC6-4E22-BEF7-1B6D6385119D}',30),
('{2DC1B8C5-3CEB-405B-A3AE-29DB7662DD50}','{A620DF4F-109E-4B8C-B337-662E41DE7FCC}','{E3D5D9F4-2619-4C7B-BA53-4808A766E688}',65),
('{A0274D8D-E472-4B42-8569-47A523340EA8}','{338E9AB4-96A6-4D2D-AB24-14FD19BDA0C6}','{76A25BD4-38D0-40C7-9E1E-43C4CAE91ACF}',15),
('{67A511BF-39E3-4024-AB6B-D1CF24EE6D40}','{338E9AB4-96A6-4D2D-AB24-14FD19BDA0C6}','{0D270274-2C55-41BB-8EDA-F5F2CE46CC06}',15),
('{2711FD5F-1C0D-47CB-A9BC-295363706FD6}','{7D6FA3EC-3A08-4F2E-A9C5-EE3526AFCF51}','{4A466061-C6B2-4F25-B34C-2F3693B7E3FE}',15),
('{E0D2FD2B-EE7A-4BE1-AA1B-A42A20F3EF29}','{7D6FA3EC-3A08-4F2E-A9C5-EE3526AFCF51}','{6E6DD40E-F177-4CCF-9602-72211C9209D6}',10),
('{EA09C5DA-817F-46E0-B147-9E49876E1C1B}','{2A77ADCE-C5D5-428D-A1B4-65A20FCDFD76}','{2851E425-6FC6-4E22-BEF7-1B6D6385119D}',5),
('{48A29209-7F55-4DC0-A3E4-38F729144D36}','{2A77ADCE-C5D5-428D-A1B4-65A20FCDFD76}','{E3D5D9F4-2619-4C7B-BA53-4808A766E688}',20);

insert into person_characteristics values
('{8F212F57-16E8-49D2-BBD5-7A62C5A1625E}','{5BE36B8B-E86A-417F-B455-3857A11F3AB8}',100,500,0,1),
('{2034A916-2FFA-4BE8-AB05-7C72D5C08D26}','{9C963EFF-BBEB-407F-9080-E94F142B66B2}',100,500,0,1),
('{B2372B8C-F352-473A-9EE4-EFD09125B2BF}','{6C9CFBE1-2C0D-42E5-BC9D-EB3D9BBCBEC1}',300,200,0,1),
('{51B1897C-7133-494D-A75F-EC8135D952F6}','{D91322B1-2892-45E5-ADD0-019F63E87FBD}',120,550,50,2),
('{08F65252-49BA-4DBF-AFA9-39DB2455C589}','{53675DEE-48D3-42EA-A1CE-45B6DCBC3B46}',500,200,300,4),
('{4150E815-C53F-4135-B38B-E2265488444F}','{31FF39E0-1F57-446A-A7D6-7D3427569BB7}',700,300,50,10),
('{BCC166FD-839A-4EF8-AE9E-B115904FBBF3}','{A620DF4F-109E-4B8C-B337-662E41DE7FCC}',300,1500,350,9),
('{FFBDC9FA-8A18-4B03-8F42-AD20DCEBE16D}','{338E9AB4-96A6-4D2D-AB24-14FD19BDA0C6}',350,250,100,2),
('{A86F076A-E0FE-4611-8D71-9FE64A7FDF4B}','{7D6FA3EC-3A08-4F2E-A9C5-EE3526AFCF51}',100,500,20,1),
('{B30A19AA-FF72-4074-8814-A62897CF37B6}','{2A77ADCE-C5D5-428D-A1B4-65A20FCDFD76}',100,500,50,1);