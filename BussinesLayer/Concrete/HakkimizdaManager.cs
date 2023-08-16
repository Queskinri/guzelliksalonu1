﻿using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class HakkimizdaManager : IHakkimizdaService
    {
        IHakkimizdaDal _hakkimizdaDal;

        public HakkimizdaManager(IHakkimizdaDal hakkimizdaDal)
        {
            _hakkimizdaDal = hakkimizdaDal;
        }
        public void TAdd(Hakkimizda t)
        {
            _hakkimizdaDal.Insert(t);
        }

        public void TDelete(Hakkimizda t)
        {
            _hakkimizdaDal.Delete(t);
        }

        public Hakkimizda TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Hakkimizda> TGetList()
        {
            return _hakkimizdaDal.Getlist();
        }

        public void TUpdate(Hakkimizda t)
        {
            _hakkimizdaDal.Update(t);
        }
    }
}
