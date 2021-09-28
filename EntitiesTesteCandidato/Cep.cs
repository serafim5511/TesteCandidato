﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesTesteCandidato
{
    public class Cep
    {
        public int Id { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public int unidade { get; set; }
        public int ibge { get; set; }
        public string gia { get; set; }
        //CREATE TABLE [dbo].[CEP] (
        //    [Id]          INT            IDENTITY (1, 1) NOT NULL,
        //    [cep]         CHAR (9)       NULL,
        //    [logradouro]  NVARCHAR (500) NULL,
        //    [complemento] NVARCHAR (500) NULL,
        //    [bairro]      NVARCHAR (500) NULL,
        //    [localidade]  NVARCHAR (500) NULL,
        //    [uf]          CHAR (2)       NULL,
        //    [unidade]     BIGINT         NULL,
        //    [ibge]        INT            NULL,
        //    [gia]         NVARCHAR (500) NULL
        //);
    }
}
