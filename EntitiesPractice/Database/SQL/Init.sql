-- Table: public."Roles"

-- DROP TABLE public."Roles";

CREATE TABLE public."Roles"
(
  id integer NOT NULL,
  role character(20),
  CONSTRAINT "Roles_pkey" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public."Roles"
  OWNER TO postgres;

  -- Table: public."Users"

-- DROP TABLE public."Users";

CREATE TABLE public."Users"
(
  id integer NOT NULL,
  name character(100),
  password character(100),
  CONSTRAINT "Users_pkey" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public."Users"
  OWNER TO postgres;
