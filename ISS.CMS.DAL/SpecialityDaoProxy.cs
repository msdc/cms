using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.IDAL;
using ISS.CMS.Model;
namespace ISS.CMS.DAL
{
    public class SpecialityDaoProxy : ISpeciality
    {
        private ISpeciality speciality;
        public SpecialityDaoProxy()
        {
            speciality = new SpecialityDaoImpl();
        }
        public int Add(Speciality model)
        {
            return speciality.Add(model);
        }

        public bool Update(Speciality model)
        {
            return speciality.Update(model);
        }

        public bool Delete(int Id)
        {
            return speciality.Delete(Id);
        }

        public bool DeleteList(string Idlist)
        {
            return speciality.DeleteList(Idlist);
        }

        public Speciality GetModel(int Id)
        {
            return speciality.GetModel(Id);
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            return speciality.GetList(strWhere);
        }

        public System.Data.DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return speciality.GetList(Top, strWhere, filedOrder);
        }

        public int GetRecordCount(string strWhere)
        {
            return speciality.GetRecordCount(strWhere);
        }

        public System.Data.DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return speciality.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }

        public System.Data.DataSet GetSpeciality()
        {
            return speciality.GetSpeciality();
        }
    }
}
