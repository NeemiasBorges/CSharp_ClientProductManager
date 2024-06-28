toc.dat                                                                                             0000600 0004000 0002000 00000031606 14637403464 0014460 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        PGDMP        +                |            teste_tecnico    16.3    16.3 1               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                    0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                    0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                    1262    16609    teste_tecnico    DATABASE     �   CREATE DATABASE teste_tecnico WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Portuguese_Brazil.1252';
    DROP DATABASE teste_tecnico;
                postgres    false         �            1259    16612    clientes    TABLE     �   CREATE TABLE public.clientes (
    id integer NOT NULL,
    nome character varying(100),
    id_endereco integer,
    id_telefone integer,
    email character varying(100)
);
    DROP TABLE public.clientes;
       public         heap    postgres    false         �            1259    16611    clientes_id_seq    SEQUENCE     �   CREATE SEQUENCE public.clientes_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.clientes_id_seq;
       public          postgres    false    216                    0    0    clientes_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.clientes_id_seq OWNED BY public.clientes.id;
          public          postgres    false    215         �            1259    16662    contato    TABLE     c   CREATE TABLE public.contato (
    id integer NOT NULL,
    nome character varying(100) NOT NULL
);
    DROP TABLE public.contato;
       public         heap    postgres    false         �            1259    16661    contato_id_seq    SEQUENCE     �   CREATE SEQUENCE public.contato_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.contato_id_seq;
       public          postgres    false    226                     0    0    contato_id_seq    SEQUENCE OWNED BY     A   ALTER SEQUENCE public.contato_id_seq OWNED BY public.contato.id;
          public          postgres    false    225         �            1259    16655    endereco    TABLE     d   CREATE TABLE public.endereco (
    id integer NOT NULL,
    nome character varying(100) NOT NULL
);
    DROP TABLE public.endereco;
       public         heap    postgres    false         �            1259    16654    endereco_id_seq    SEQUENCE     �   CREATE SEQUENCE public.endereco_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.endereco_id_seq;
       public          postgres    false    224         !           0    0    endereco_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.endereco_id_seq OWNED BY public.endereco.id;
          public          postgres    false    223         �            1259    16619    produto    TABLE     �   CREATE TABLE public.produto (
    id integer NOT NULL,
    nome character varying(100),
    descricao character varying(255),
    preco numeric(10,2)
);
    DROP TABLE public.produto;
       public         heap    postgres    false         �            1259    16618    produto_id_seq    SEQUENCE     �   CREATE SEQUENCE public.produto_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.produto_id_seq;
       public          postgres    false    218         "           0    0    produto_id_seq    SEQUENCE OWNED BY     A   ALTER SEQUENCE public.produto_id_seq OWNED BY public.produto.id;
          public          postgres    false    217         �            1259    16626    vendas    TABLE     �   CREATE TABLE public.vendas (
    id integer NOT NULL,
    data_criacao timestamp without time zone,
    id_usuario integer,
    id_cliente integer
);
    DROP TABLE public.vendas;
       public         heap    postgres    false         �            1259    16625    vendas_id_seq    SEQUENCE     �   CREATE SEQUENCE public.vendas_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 $   DROP SEQUENCE public.vendas_id_seq;
       public          postgres    false    220         #           0    0    vendas_id_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.vendas_id_seq OWNED BY public.vendas.id;
          public          postgres    false    219         �            1259    16638    vendascorpo    TABLE     �   CREATE TABLE public.vendascorpo (
    id integer NOT NULL,
    id_venda integer,
    id_produto integer,
    id_estoque integer,
    quantidade double precision,
    preco numeric(10,2)
);
    DROP TABLE public.vendascorpo;
       public         heap    postgres    false         �            1259    16637    vendascorpo_id_seq    SEQUENCE     �   CREATE SEQUENCE public.vendascorpo_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.vendascorpo_id_seq;
       public          postgres    false    222         $           0    0    vendascorpo_id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.vendascorpo_id_seq OWNED BY public.vendascorpo.id;
          public          postgres    false    221         i           2604    16615    clientes id    DEFAULT     j   ALTER TABLE ONLY public.clientes ALTER COLUMN id SET DEFAULT nextval('public.clientes_id_seq'::regclass);
 :   ALTER TABLE public.clientes ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    216    215    216         n           2604    16665 
   contato id    DEFAULT     h   ALTER TABLE ONLY public.contato ALTER COLUMN id SET DEFAULT nextval('public.contato_id_seq'::regclass);
 9   ALTER TABLE public.contato ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    225    226    226         m           2604    16658    endereco id    DEFAULT     j   ALTER TABLE ONLY public.endereco ALTER COLUMN id SET DEFAULT nextval('public.endereco_id_seq'::regclass);
 :   ALTER TABLE public.endereco ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    223    224    224         j           2604    16622 
   produto id    DEFAULT     h   ALTER TABLE ONLY public.produto ALTER COLUMN id SET DEFAULT nextval('public.produto_id_seq'::regclass);
 9   ALTER TABLE public.produto ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    218    217    218         k           2604    16629 	   vendas id    DEFAULT     f   ALTER TABLE ONLY public.vendas ALTER COLUMN id SET DEFAULT nextval('public.vendas_id_seq'::regclass);
 8   ALTER TABLE public.vendas ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    220    219    220         l           2604    16641    vendascorpo id    DEFAULT     p   ALTER TABLE ONLY public.vendascorpo ALTER COLUMN id SET DEFAULT nextval('public.vendascorpo_id_seq'::regclass);
 =   ALTER TABLE public.vendascorpo ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    222    221    222                   0    16612    clientes 
   TABLE DATA           M   COPY public.clientes (id, nome, id_endereco, id_telefone, email) FROM stdin;
    public          postgres    false    216       4878.dat           0    16662    contato 
   TABLE DATA           +   COPY public.contato (id, nome) FROM stdin;
    public          postgres    false    226       4888.dat           0    16655    endereco 
   TABLE DATA           ,   COPY public.endereco (id, nome) FROM stdin;
    public          postgres    false    224       4886.dat           0    16619    produto 
   TABLE DATA           =   COPY public.produto (id, nome, descricao, preco) FROM stdin;
    public          postgres    false    218       4880.dat           0    16626    vendas 
   TABLE DATA           J   COPY public.vendas (id, data_criacao, id_usuario, id_cliente) FROM stdin;
    public          postgres    false    220       4882.dat           0    16638    vendascorpo 
   TABLE DATA           ^   COPY public.vendascorpo (id, id_venda, id_produto, id_estoque, quantidade, preco) FROM stdin;
    public          postgres    false    222       4884.dat %           0    0    clientes_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.clientes_id_seq', 5, true);
          public          postgres    false    215         &           0    0    contato_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.contato_id_seq', 8, true);
          public          postgres    false    225         '           0    0    endereco_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.endereco_id_seq', 6, true);
          public          postgres    false    223         (           0    0    produto_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.produto_id_seq', 4, true);
          public          postgres    false    217         )           0    0    vendas_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.vendas_id_seq', 7, true);
          public          postgres    false    219         *           0    0    vendascorpo_id_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.vendascorpo_id_seq', 11, true);
          public          postgres    false    221         p           2606    16617    clientes clientes_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.clientes
    ADD CONSTRAINT clientes_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.clientes DROP CONSTRAINT clientes_pkey;
       public            postgres    false    216         z           2606    16667    contato contato_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.contato
    ADD CONSTRAINT contato_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.contato DROP CONSTRAINT contato_pkey;
       public            postgres    false    226         x           2606    16660    endereco endereco_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.endereco
    ADD CONSTRAINT endereco_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.endereco DROP CONSTRAINT endereco_pkey;
       public            postgres    false    224         r           2606    16624    produto produto_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.produto
    ADD CONSTRAINT produto_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.produto DROP CONSTRAINT produto_pkey;
       public            postgres    false    218         t           2606    16631    vendas vendas_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.vendas
    ADD CONSTRAINT vendas_pkey PRIMARY KEY (id);
 <   ALTER TABLE ONLY public.vendas DROP CONSTRAINT vendas_pkey;
       public            postgres    false    220         v           2606    16643    vendascorpo vendascorpo_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.vendascorpo
    ADD CONSTRAINT vendascorpo_pkey PRIMARY KEY (id);
 F   ALTER TABLE ONLY public.vendascorpo DROP CONSTRAINT vendascorpo_pkey;
       public            postgres    false    222         {           2606    16632    vendas vendas_id_cliente_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.vendas
    ADD CONSTRAINT vendas_id_cliente_fkey FOREIGN KEY (id_cliente) REFERENCES public.clientes(id);
 G   ALTER TABLE ONLY public.vendas DROP CONSTRAINT vendas_id_cliente_fkey;
       public          postgres    false    220    216    4720         |           2606    16649 '   vendascorpo vendascorpo_id_produto_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.vendascorpo
    ADD CONSTRAINT vendascorpo_id_produto_fkey FOREIGN KEY (id_produto) REFERENCES public.produto(id);
 Q   ALTER TABLE ONLY public.vendascorpo DROP CONSTRAINT vendascorpo_id_produto_fkey;
       public          postgres    false    4722    222    218         }           2606    16644 %   vendascorpo vendascorpo_id_venda_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.vendascorpo
    ADD CONSTRAINT vendascorpo_id_venda_fkey FOREIGN KEY (id_venda) REFERENCES public.vendas(id);
 O   ALTER TABLE ONLY public.vendascorpo DROP CONSTRAINT vendascorpo_id_venda_fkey;
       public          postgres    false    220    222    4724                                                                                                                                  4878.dat                                                                                            0000600 0004000 0002000 00000000176 14637403464 0014303 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        2	Novo Cliente	3	5	email@email.com
3	Cliente Dois	4	6	email@email.com
4	teste	5	7	em
5	Cliente Teste	6	8	email@email.com
\.


                                                                                                                                                                                                                                                                                                                                                                                                  4888.dat                                                                                            0000600 0004000 0002000 00000000122 14637403464 0014273 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	11111111
2	111111
3	12321313
5	11123123
6	12313123
7	123123
8	11 1111-1111
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                              4886.dat                                                                                            0000600 0004000 0002000 00000000077 14637403464 0014302 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	enredego
3	Endereco Teste
4	enddois
5	end
6	Endereco Um
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                 4880.dat                                                                                            0000600 0004000 0002000 00000000136 14637403464 0014270 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        2	Produto Teste	test	223.00
3	novo	produto novo	12.00
4	Produto	Produto de testes	200.00
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                  4882.dat                                                                                            0000600 0004000 0002000 00000000354 14637403464 0014274 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	2024-06-25 02:31:30.315772	0	2
2	2024-06-25 02:31:30.315772	0	2
3	2024-06-26 05:31:40.658893	0	3
4	2024-06-26 05:38:02.821462	0	2
5	2024-06-27 19:57:29.012144	0	3
6	2024-06-27 19:57:44.479447	0	2
7	2024-06-27 21:12:53.938375	0	5
\.


                                                                                                                                                                                                                                                                                    4884.dat                                                                                            0000600 0004000 0002000 00000000300 14637403464 0014265 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	1	2	\N	\N	2.00
2	1	3	\N	\N	4.00
3	2	2	\N	1	2.00
4	2	3	\N	3	4.00
5	3	2	\N	12	2.00
6	4	2	\N	32	12.00
7	6	3	\N	43	4.00
8	6	2	\N	2	41.00
9	7	2	\N	2	3.00
10	7	3	\N	21	10.00
11	7	4	\N	4	3.00
\.


                                                                                                                                                                                                                                                                                                                                restore.sql                                                                                         0000600 0004000 0002000 00000024754 14637403464 0015413 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        --
-- NOTE:
--
-- File paths need to be edited. Search for $$PATH$$ and
-- replace it with the path to the directory containing
-- the extracted data files.
--
--
-- PostgreSQL database dump
--

-- Dumped from database version 16.3
-- Dumped by pg_dump version 16.3

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

DROP DATABASE teste_tecnico;
--
-- Name: teste_tecnico; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE teste_tecnico WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Portuguese_Brazil.1252';


ALTER DATABASE teste_tecnico OWNER TO postgres;

\connect teste_tecnico

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: clientes; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.clientes (
    id integer NOT NULL,
    nome character varying(100),
    id_endereco integer,
    id_telefone integer,
    email character varying(100)
);


ALTER TABLE public.clientes OWNER TO postgres;

--
-- Name: clientes_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.clientes_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.clientes_id_seq OWNER TO postgres;

--
-- Name: clientes_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.clientes_id_seq OWNED BY public.clientes.id;


--
-- Name: contato; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.contato (
    id integer NOT NULL,
    nome character varying(100) NOT NULL
);


ALTER TABLE public.contato OWNER TO postgres;

--
-- Name: contato_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.contato_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.contato_id_seq OWNER TO postgres;

--
-- Name: contato_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.contato_id_seq OWNED BY public.contato.id;


--
-- Name: endereco; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.endereco (
    id integer NOT NULL,
    nome character varying(100) NOT NULL
);


ALTER TABLE public.endereco OWNER TO postgres;

--
-- Name: endereco_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.endereco_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.endereco_id_seq OWNER TO postgres;

--
-- Name: endereco_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.endereco_id_seq OWNED BY public.endereco.id;


--
-- Name: produto; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.produto (
    id integer NOT NULL,
    nome character varying(100),
    descricao character varying(255),
    preco numeric(10,2)
);


ALTER TABLE public.produto OWNER TO postgres;

--
-- Name: produto_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.produto_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.produto_id_seq OWNER TO postgres;

--
-- Name: produto_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.produto_id_seq OWNED BY public.produto.id;


--
-- Name: vendas; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.vendas (
    id integer NOT NULL,
    data_criacao timestamp without time zone,
    id_usuario integer,
    id_cliente integer
);


ALTER TABLE public.vendas OWNER TO postgres;

--
-- Name: vendas_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.vendas_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.vendas_id_seq OWNER TO postgres;

--
-- Name: vendas_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.vendas_id_seq OWNED BY public.vendas.id;


--
-- Name: vendascorpo; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.vendascorpo (
    id integer NOT NULL,
    id_venda integer,
    id_produto integer,
    id_estoque integer,
    quantidade double precision,
    preco numeric(10,2)
);


ALTER TABLE public.vendascorpo OWNER TO postgres;

--
-- Name: vendascorpo_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.vendascorpo_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.vendascorpo_id_seq OWNER TO postgres;

--
-- Name: vendascorpo_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.vendascorpo_id_seq OWNED BY public.vendascorpo.id;


--
-- Name: clientes id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.clientes ALTER COLUMN id SET DEFAULT nextval('public.clientes_id_seq'::regclass);


--
-- Name: contato id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.contato ALTER COLUMN id SET DEFAULT nextval('public.contato_id_seq'::regclass);


--
-- Name: endereco id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.endereco ALTER COLUMN id SET DEFAULT nextval('public.endereco_id_seq'::regclass);


--
-- Name: produto id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.produto ALTER COLUMN id SET DEFAULT nextval('public.produto_id_seq'::regclass);


--
-- Name: vendas id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vendas ALTER COLUMN id SET DEFAULT nextval('public.vendas_id_seq'::regclass);


--
-- Name: vendascorpo id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vendascorpo ALTER COLUMN id SET DEFAULT nextval('public.vendascorpo_id_seq'::regclass);


--
-- Data for Name: clientes; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.clientes (id, nome, id_endereco, id_telefone, email) FROM stdin;
\.
COPY public.clientes (id, nome, id_endereco, id_telefone, email) FROM '$$PATH$$/4878.dat';

--
-- Data for Name: contato; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.contato (id, nome) FROM stdin;
\.
COPY public.contato (id, nome) FROM '$$PATH$$/4888.dat';

--
-- Data for Name: endereco; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.endereco (id, nome) FROM stdin;
\.
COPY public.endereco (id, nome) FROM '$$PATH$$/4886.dat';

--
-- Data for Name: produto; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.produto (id, nome, descricao, preco) FROM stdin;
\.
COPY public.produto (id, nome, descricao, preco) FROM '$$PATH$$/4880.dat';

--
-- Data for Name: vendas; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.vendas (id, data_criacao, id_usuario, id_cliente) FROM stdin;
\.
COPY public.vendas (id, data_criacao, id_usuario, id_cliente) FROM '$$PATH$$/4882.dat';

--
-- Data for Name: vendascorpo; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.vendascorpo (id, id_venda, id_produto, id_estoque, quantidade, preco) FROM stdin;
\.
COPY public.vendascorpo (id, id_venda, id_produto, id_estoque, quantidade, preco) FROM '$$PATH$$/4884.dat';

--
-- Name: clientes_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.clientes_id_seq', 5, true);


--
-- Name: contato_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.contato_id_seq', 8, true);


--
-- Name: endereco_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.endereco_id_seq', 6, true);


--
-- Name: produto_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.produto_id_seq', 4, true);


--
-- Name: vendas_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.vendas_id_seq', 7, true);


--
-- Name: vendascorpo_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.vendascorpo_id_seq', 11, true);


--
-- Name: clientes clientes_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.clientes
    ADD CONSTRAINT clientes_pkey PRIMARY KEY (id);


--
-- Name: contato contato_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.contato
    ADD CONSTRAINT contato_pkey PRIMARY KEY (id);


--
-- Name: endereco endereco_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.endereco
    ADD CONSTRAINT endereco_pkey PRIMARY KEY (id);


--
-- Name: produto produto_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.produto
    ADD CONSTRAINT produto_pkey PRIMARY KEY (id);


--
-- Name: vendas vendas_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vendas
    ADD CONSTRAINT vendas_pkey PRIMARY KEY (id);


--
-- Name: vendascorpo vendascorpo_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vendascorpo
    ADD CONSTRAINT vendascorpo_pkey PRIMARY KEY (id);


--
-- Name: vendas vendas_id_cliente_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vendas
    ADD CONSTRAINT vendas_id_cliente_fkey FOREIGN KEY (id_cliente) REFERENCES public.clientes(id);


--
-- Name: vendascorpo vendascorpo_id_produto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vendascorpo
    ADD CONSTRAINT vendascorpo_id_produto_fkey FOREIGN KEY (id_produto) REFERENCES public.produto(id);


--
-- Name: vendascorpo vendascorpo_id_venda_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vendascorpo
    ADD CONSTRAINT vendascorpo_id_venda_fkey FOREIGN KEY (id_venda) REFERENCES public.vendas(id);


--
-- PostgreSQL database dump complete
--

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    