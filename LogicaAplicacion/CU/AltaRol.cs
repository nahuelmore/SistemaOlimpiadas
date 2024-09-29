﻿using DTO.Mappers;
using DTO.Objetos;
using LogicaAplicacion.ICU;
using LogicaNegocio.EntidadesDominio;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CU
{
    public class AltaRol : IAltaRol
    {
        public IRepositorioRoles Repo { get; set; }

        public AltaRol(IRepositorioRoles repo)
        {
            Repo = repo;
        }

        public void Alta(RolDTO dto)
        {
            Rol nuevo = RolesMapper.ToRol(dto);
            Repo.Add(nuevo);
        }
    }
}