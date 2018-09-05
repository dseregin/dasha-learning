CREATE TABLE "public".classes ( 
	id                   uuid  NOT NULL ,
	name                 varchar(100)   ,
	some_characteristics varchar   ,
	CONSTRAINT pk_classes_id PRIMARY KEY ( id )
 ) ;

CREATE TABLE "public".skills ( 
	id                   uuid  NOT NULL ,
	name                 varchar(100)   ,
	description          varchar   ,
	CONSTRAINT pk_skills_id PRIMARY KEY ( id )
 ) ;

CREATE TABLE "public".types ( 
	id                   uuid  NOT NULL ,
	name                 varchar(100)   ,
	CONSTRAINT pk_types_id PRIMARY KEY ( id )
 ) ;

CREATE TABLE "public".users ( 
	id                   uuid  NOT NULL ,
	login                varchar  NOT NULL ,
	"password"           varchar  NOT NULL ,
	is_online            bool   ,
	last_online_date     timestamp   ,
	CONSTRAINT pk_users_id PRIMARY KEY ( id )
 ) ;

CREATE TABLE "public".items ( 
	id                   uuid  NOT NULL ,
	name                 varchar(100)   ,
	description          varchar   ,
	type_id              uuid   ,
	CONSTRAINT pk_items_id PRIMARY KEY ( id )
 ) ;

CREATE INDEX idx_items_type_id ON "public".items ( type_id ) ;

CREATE TABLE "public".persons ( 
	id                   uuid  NOT NULL ,
	user_id              uuid   ,
	name                 varchar(100)   ,
	male                 bool   ,
	class_id             uuid   ,
	CONSTRAINT pk_character_id PRIMARY KEY ( id )
 ) ;

CREATE INDEX idx_character_user_id ON "public".persons ( user_id ) ;

CREATE INDEX idx_character_class_id ON "public".persons ( class_id ) ;

COMMENT ON COLUMN "public".persons.male IS 'мужской или женский пол';

CREATE TABLE "public".persons_skills ( 
	id                   uuid  NOT NULL ,
	person_id            uuid   ,
	skill_id             uuid   ,
	power_value          integer   ,
	CONSTRAINT pk_characters_skills_id PRIMARY KEY ( id )
 ) ;

CREATE INDEX idx_persons_skills_person_id ON "public".persons_skills ( person_id ) ;

CREATE INDEX idx_persons_skills_skill_id ON "public".persons_skills ( skill_id ) ;

CREATE TABLE "public".stats ( 
	id                   uuid  NOT NULL ,
	intellect_value      integer   ,
	agility_value        integer   ,
	strenght_value       integer   ,
	person_id            uuid   ,
	CONSTRAINT pk_stats_id PRIMARY KEY ( id )
 ) ;

CREATE INDEX idx_stats_character_id ON "public".stats ( person_id ) ;

CREATE TABLE "public".items_persons ( 
	id                   uuid  NOT NULL ,
	person_id            uuid   ,
	item_id              uuid   ,
	"count"              integer   ,
	CONSTRAINT pk_items_characters_id PRIMARY KEY ( id )
 ) ;

CREATE INDEX idx_items_persons_person_id ON "public".items_persons ( person_id ) ;

CREATE INDEX idx_items_persons_item_id ON "public".items_persons ( item_id ) ;

CREATE TABLE "public".person_characteristics ( 
	id                   uuid  NOT NULL ,
	person_id            uuid   ,
	max_hp               integer   ,
	max_mana             integer   ,
	experience           integer   ,
	"level"              integer   ,
	CONSTRAINT pk_characteristics_id PRIMARY KEY ( id )
 ) ;

CREATE INDEX idx_person_characteristics_person_id ON "public".person_characteristics ( person_id ) ;

ALTER TABLE "public".items ADD CONSTRAINT fk_items_types FOREIGN KEY ( type_id ) REFERENCES "public".types( id )  ;

ALTER TABLE "public".persons ADD CONSTRAINT fk_character_users FOREIGN KEY ( user_id ) REFERENCES "public".users( id )  ;

ALTER TABLE "public".persons ADD CONSTRAINT fk_character_classes FOREIGN KEY ( class_id ) REFERENCES "public".classes( id )  ;

ALTER TABLE "public".persons_skills ADD CONSTRAINT fk_characters_skills_person FOREIGN KEY ( person_id ) REFERENCES "public".persons( id )  ;

ALTER TABLE "public".persons_skills ADD CONSTRAINT fk_persons_skills_skills FOREIGN KEY ( skill_id ) REFERENCES "public".skills( id )  ;

ALTER TABLE "public".stats ADD CONSTRAINT fk_stats_person FOREIGN KEY ( person_id ) REFERENCES "public".persons( id )  ;

ALTER TABLE "public".items_persons ADD CONSTRAINT fk_items_persons_person FOREIGN KEY ( person_id ) REFERENCES "public".persons( id )  ;

ALTER TABLE "public".items_persons ADD CONSTRAINT fk_items_persons_items FOREIGN KEY ( item_id ) REFERENCES "public".items( id )  ;

ALTER TABLE "public".person_characteristics ADD CONSTRAINT fk_person_characteristics FOREIGN KEY ( person_id ) REFERENCES "public".persons( id )  ;