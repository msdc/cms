using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;
using ISS.CMS.Model;
using System.ComponentModel;
namespace ISS.CMS.DAL
{
    public class ModelHandler<T>
    {
        /// <summary>
        /// 实体列表转为DataTable 注意：使用本方法，须要实体中的每个属性必须添加DataFieldAttribute特性
        /// </summary>
        /// <param name="objlist">实体列表</param>
        /// <returns>返回DataTable</returns>
        public static System.Data.DataTable Model2DataTable(List<T> objlist)
        {
            if (objlist.Count == 0) return null;
            DataTable dt = GeneratorDataTable(typeof(T));
            foreach (T obj in objlist)
            {
                Type modelType = obj.GetType();
                PropertyInfo[] properties = modelType.GetProperties();
                DataRow dr = dt.NewRow();
                for (int i = 0; i < properties.Length; i++)
                {
                    dr[i] = properties[i].GetGetMethod().Invoke(obj, null);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
        private static DataTable GeneratorDataTable(Type modelType)
        {
            //Type modelType = obj.GetType();
            PropertyInfo[] properties = modelType.GetProperties();
            DataFiledAttribute d = null;
            DataTable dt = new DataTable();
            for (int i = 0; i < properties.Length; i++)
            {
                DataColumn dc = new DataColumn();
                d = Attribute.GetCustomAttribute(properties[i], typeof(DataFiledAttribute)) as DataFiledAttribute;
                dc.ColumnName = d.FieldName;
                dc.DataType = typeof(string);
                dt.Columns.Add(dc);

            }
            return dt;
        }
        /// <summary>
        /// DataTable转为实体列表
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static List<T> DataTable2Model(DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<T> list = new List<T>();

            foreach (DataRow dr in dt.Rows)
            {
                T obj = Activator.CreateInstance<T>();
                foreach (DataColumn dc in dt.Columns)
                {
                    PropertyInfo info = obj.GetType().GetProperty(dc.ColumnName, BindingFlags.Public | BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.GetProperty);
                    //if (dr[dc] != DBNull.Value)
                    //{
                    //    Type t = info.PropertyType;
                    //    info.SetValue(obj, Convert.ChangeType(dr[dc], t), null);
                    //}
                    //else
                    //{
                    //    info.SetValue(obj, null, null);
                    //}

                    Type t = info.PropertyType;

                    info.SetValue(obj, ChangeType(dr[dc], t), null);
                }
                list.Add(obj);
            }
            return list;

        }
        /// <summary>
        /// 处理可空类型的转换
        /// </summary>
        /// <param name="value"></param>
        /// <param name="conversionType"></param>
        /// <returns></returns>
        private static object ChangeType(object value, Type conversionType)
        {
            if (conversionType.IsGenericType && conversionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value != null)
                {
                    NullableConverter nullableConverter = new NullableConverter(conversionType);
                    conversionType = nullableConverter.UnderlyingType;
                }
                else
                {
                    return null;
                }
            }
            return Convert.ChangeType(value, conversionType);
        }
    }
}
