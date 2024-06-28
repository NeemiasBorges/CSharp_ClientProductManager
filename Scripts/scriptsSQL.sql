--
-- PostgreSQL database dump
--

-- Dumped from database version 16.3
-- Dumped by pg_dump version 16.3

-- Started on 2024-06-27 21:57:04

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
-- TOC entry 216 (class 1259 OID 16612)
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
-- TOC entry 215 (class 1259 OID 16611)
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
-- TOC entry 4894 (class 0 OID 0)
-- Dependencies: 215
-- Name: clientes_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.clientes_id_seq OWNED BY public.clientes.id;


--
-- TOC entry 226 (class 1259 OID 16662)
-- Name: contato; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.contato (
    id integer NOT NULL,
    nome character varying(100) NOT NULL
);


ALTER TABLE public.contato OWNER TO postgres;

--
-- TOC entry 225 (class 1259 OID 16661)
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
-- TOC entry 4895 (class 0 OID 0)
-- Dependencies: 225
-- Name: contato_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.contato_id_seq OWNED BY public.contato.id;


--
-- TOC entry 224 (class 1259 OID 16655)
-- Name: endereco; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.endereco (
    id integer NOT NULL,
    nome character varying(100) NOT NULL
);


ALTER TABLE public.endereco OWNER TO postgres;

--
-- TOC entry 223 (class 1259 OID 16654)
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
-- TOC entry 4896 (class 0 OID 0)
-- Dependencies: 223
-- Name: endereco_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.endereco_id_seq OWNED BY public.endereco.id;


--
-- TOC entry 218 (class 1259 OID 16619)
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
-- TOC entry 217 (class 1259 OID 16618)
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
-- TOC entry 4897 (class 0 OID 0)
-- Dependencies: 217
-- Name: produto_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.produto_id_seq OWNED BY public.produto.id;


--
-- TOC entry 220 (class 1259 OID 16626)
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
-- TOC entry 219 (class 1259 OID 16625)
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
-- TOC entry 4898 (class 0 OID 0)
-- Dependencies: 219
-- Name: vendas_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.vendas_id_seq OWNED BY public.vendas.id;


--
-- TOC entry 222 (class 1259 OID 16638)
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
-- TOC entry 221 (class 1259 OID 16637)
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
-- TOC entry 4899 (class 0 OID 0)
-- Dependencies: 221
-- Name: vendascorpo_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.vendascorpo_id_seq OWNED BY public.vendascorpo.id;


--
-- TOC entry 4713 (class 2604 OID 16615)
-- Name: clientes id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.clientes ALTER COLUMN id SET DEFAULT nextval('public.clientes_id_seq'::regclass);


--
-- TOC entry 4718 (class 2604 OID 16665)
-- Name: contato id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.contato ALTER COLUMN id SET DEFAULT nextval('public.contato_id_seq'::regclass);


--
-- TOC entry 4717 (class 2604 OID 16658)
-- Name: endereco id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.endereco ALTER COLUMN id SET DEFAULT nextval('public.endereco_id_seq'::regclass);


--
-- TOC entry 4714 (class 2604 OID 16622)
-- Name: produto id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.produto ALTER COLUMN id SET DEFAULT nextval('public.produto_id_seq'::regclass);


--
-- TOC entry 4715 (class 2604 OID 16629)
-- Name: vendas id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vendas ALTER COLUMN id SET DEFAULT nextval('public.vendas_id_seq'::regclass);


--
-- TOC entry 4716 (class 2604 OID 16641)
-- Name: vendascorpo id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vendascorpo ALTER COLUMN id SET DEFAULT nextval('public.vendascorpo_id_seq'::regclass);


--
-- TOC entry 4878 (class 0 OID 16612)
-- Dependencies: 216
-- Data for Name: clientes; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.clientes (id, nome, id_endereco, id_telefone, email) FROM stdin;
2	Novo Cliente	3	5	email@email.com
3	Cliente Dois	4	6	email@email.com
4	teste	5	7	em
5	Cliente Teste	6	8	email@email.com
\.


--
-- TOC entry 4888 (class 0 OID 16662)
-- Dependencies: 226
-- Data for Name: contato; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.contato (id, nome) FROM stdin;
1	11111111
2	111111
3	12321313
5	11123123
6	12313123
7	123123
8	11 1111-1111
\.


--
-- TOC entry 4886 (class 0 OID 16655)
-- Dependencies: 224
-- Data for Name: endereco; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.endereco (id, nome) FROM stdin;
1	enredego
3	Endereco Teste
4	enddois
5	end
6	Endereco Um
\.


--
-- TOC entry 4880 (class 0 OID 16619)
-- Dependencies: 218
-- Data for Name: produto; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.produto (id, nome, descricao, preco) FROM stdin;
2	Produto Teste	test	223.00
3	novo	produto novo	12.00
4	Produto	Produto de testes	200.00
\.


--
-- TOC entry 4882 (class 0 OID 16626)
-- Dependencies: 220
-- Data for Name: vendas; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.vendas (id, data_criacao, id_usuario, id_cliente) FROM stdin;
1	2024-06-25 02:31:30.315772	0	2
2	2024-06-25 02:31:30.315772	0	2
3	2024-06-26 05:31:40.658893	0	3
4	2024-06-26 05:38:02.821462	0	2
5	2024-06-27 19:57:29.012144	0	3
6	2024-06-27 19:57:44.479447	0	2
7	2024-06-27 21:12:53.938375	0	5
\.


--
-- TOC entry 4884 (class 0 OID 16638)
-- Dependencies: 222
-- Data for Name: vendascorpo; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.vendascorpo (id, id_venda, id_produto, id_estoque, quantidade, preco) FROM stdin;
1	1	2	\N	\N	2.00
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


--
-- TOC entry 4900 (class 0 OID 0)
-- Dependencies: 215
-- Name: clientes_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.clientes_id_seq', 5, true);


--
-- TOC entry 4901 (class 0 OID 0)
-- Dependencies: 225
-- Name: contato_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.contato_id_seq', 8, true);


--
-- TOC entry 4902 (class 0 OID 0)
-- Dependencies: 223
-- Name: endereco_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.endereco_id_seq', 6, true);


--
-- TOC entry 4903 (class 0 OID 0)
-- Dependencies: 217
-- Name: produto_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.produto_id_seq', 4, true);


--
-- TOC entry 4904 (class 0 OID 0)
-- Dependencies: 219
-- Name: vendas_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.vendas_id_seq', 7, true);


--
-- TOC entry 4905 (class 0 OID 0)
-- Dependencies: 221
-- Name: vendascorpo_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.vendascorpo_id_seq', 11, true);


--
-- TOC entry 4720 (class 2606 OID 16617)
-- Name: clientes clientes_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.clientes
    ADD CONSTRAINT clientes_pkey PRIMARY KEY (id);


--
-- TOC entry 4730 (class 2606 OID 16667)
-- Name: contato contato_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.contato
    ADD CONSTRAINT contato_pkey PRIMARY KEY (id);


--
-- TOC entry 4728 (class 2606 OID 16660)
-- Name: endereco endereco_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.endereco
    ADD CONSTRAINT endereco_pkey PRIMARY KEY (id);


--
-- TOC entry 4722 (class 2606 OID 16624)
-- Name: produto produto_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.produto
    ADD CONSTRAINT produto_pkey PRIMARY KEY (id);


--
-- TOC entry 4724 (class 2606 OID 16631)
-- Name: vendas vendas_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vendas
    ADD CONSTRAINT vendas_pkey PRIMARY KEY (id);


--
-- TOC entry 4726 (class 2606 OID 16643)
-- Name: vendascorpo vendascorpo_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vendascorpo
    ADD CONSTRAINT vendascorpo_pkey PRIMARY KEY (id);


--
-- TOC entry 4731 (class 2606 OID 16632)
-- Name: vendas vendas_id_cliente_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vendas
    ADD CONSTRAINT vendas_id_cliente_fkey FOREIGN KEY (id_cliente) REFERENCES public.clientes(id);


--
-- TOC entry 4732 (class 2606 OID 16649)
-- Name: vendascorpo vendascorpo_id_produto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vendascorpo
    ADD CONSTRAINT vendascorpo_id_produto_fkey FOREIGN KEY (id_produto) REFERENCES public.produto(id);


--
-- TOC entry 4733 (class 2606 OID 16644)
-- Name: vendascorpo vendascorpo_id_venda_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vendascorpo
    ADD CONSTRAINT vendascorpo_id_venda_fkey FOREIGN KEY (id_venda) REFERENCES public.vendas(id);


-- Completed on 2024-06-27 21:57:04

--
-- PostgreSQL database dump complete
--

