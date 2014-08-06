using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using ISS.CMS.Model;
using System.Data.SqlClient;
using System.ComponentModel;
namespace ISS.CMS.DAL
{
    public class DbParameterGenerator
    {
        /// <summary>
        /// 根据实体生成Sqlparameter
        /// </summary>
        /// <param name="objEntity">实体对像</param>       
        /// <returns></returns>
        public static System.Data.SqlClient.SqlParameter[] GetParameterGenerator(object objEntity)
        {
            return GetParameterGenerator(objEntity, new string[] { }, false);
        }
        /// <summary>
        /// 根据实体生成Sqlparameter
        /// </summary>
        /// <param name="objEntity">实体对像</param>
        /// <param name="CantainProperty">指定要在参数中出现或不出现的实体属性</param>
        /// <param name="isContain">生成的参数中是否包括CantainProperty指定的属性</param>
        /// <returns></returns>
        public static System.Data.SqlClient.SqlParameter[] GetParameterGenerator(object objEntity, string[] CantainProperty, bool isContain)
        {
            if (objEntity == null) return null;
            Type objType = objEntity.GetType();
            PropertyInfo[] infos = objType.GetProperties();
            DataFiledAttribute d = null;
            int len = 0;
            bool isAll;
            if (CantainProperty != null)
            {
                if (isContain)
                {
                    len = CantainProperty.Length;
                }
                else
                {
                    len = infos.Length - CantainProperty.Length;
                }
            }
            else
            {
                return null;
            }
            isAll = CantainProperty.Length == 0 ? true : false;
            System.Data.SqlClient.SqlParameter[] sqlparams = new System.Data.SqlClient.SqlParameter[len];
            PropertyInfo info = null;
            int count = 0;
            for (int i = 0; i < infos.Length; i++)
            {
                bool isContinue = false;
                d = Attribute.GetCustomAttribute(infos[i], typeof(DataFiledAttribute)) as DataFiledAttribute;
                if (!isAll)
                {
                    if (isContain)
                    {
                        if (!CantainProperty.Contains<string>(d.FieldName, new StringComparer()))
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (CantainProperty.Contains<string>(d.FieldName, new StringComparer()))
                        {
                            continue;
                        }
                    }
                }
                SqlParameter sqlparam = null;
                if (d.FieldName.StartsWith("@"))
                {
                    sqlparam = new SqlParameter(d.FieldName, d.SqlDbType);
                }
                else
                {
                    sqlparam = new SqlParameter("@" + d.FieldName, d.SqlDbType);
                }
                if (d.IsSizeDefined)
                {
                    sqlparam.Size = d.Size;
                }
                object objValue = infos[i].GetValue(objEntity, null);
                Type t = infos[i].PropertyType;
                //switch (infos[i].PropertyType.Name.ToLower())
                //{
                //    case "string":
                //        {
                //            objvalue = objtmp == null ? "" : objtmp;
                //            break;
                //        }
                //    case "boolean":
                //        {
                //            objvalue = objtmp == null ? false : objtmp;
                //            break;
                //        }
                //    case "datetime":
                //        {
                //            objvalue = objtmp == null ? "0000-00-00" : objtmp;
                //            break;
                //        }
                //    default:
                //        {
                //            objvalue = objtmp == null ? "0" : objtmp;
                //            break;
                //        }
                //}
                sqlparam.Value = ChangeType(objValue, t);
                sqlparam.SqlDbType = d.SqlDbType;
                sqlparams[count] = sqlparam;
                if (!isContinue)
                {
                    count++;
                }

            }
            return sqlparams;
        }
        /// <summary>
        /// 根据实体生成Sqlparameter
        /// </summary>
        /// <param name="objEntity">实体对像</param>
        /// <param name="entityPropertys">实体的属性名称（不区分大小）</param>
        /// <param name="entityValue">实体的属性对应的值</param>
        /// <returns></returns>
        public static System.Data.SqlClient.SqlParameter[] GetParameterGenerator(object objEntity, string[] entityPropertys, object[] entityValue)
        {
            int n = entityPropertys.Length;
            if ((n != entityValue.Length) || n == 0)
            {
                return null;
            }
            Type objType = objEntity.GetType();
            PropertyInfo[] infos = objType.GetProperties();
            DataFiledAttribute d = null;
            System.Data.SqlClient.SqlParameter[] sqlparams = new System.Data.SqlClient.SqlParameter[n];
            PropertyInfo info = null;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < infos.Length; j++)
                {
                    if (String.Equals(infos[j].Name, entityPropertys[i], StringComparison.CurrentCultureIgnoreCase))
                    {
                        info = infos[j];
                        break;
                    }
                }
                d = Attribute.GetCustomAttribute(info, typeof(DataFiledAttribute)) as DataFiledAttribute;
                SqlParameter sqlparam = null;
                if (d.FieldName.StartsWith("@"))
                {
                    sqlparam = new SqlParameter(d.FieldName, d.SqlDbType);
                }
                else
                {
                    sqlparam = new SqlParameter("@" + d.FieldName, d.SqlDbType);
                }
                if (d.IsSizeDefined)
                {
                    sqlparam.Size = d.Size;
                }
                sqlparam.Value = entityValue[i];
                sqlparams[i] = sqlparam;
            }
            return sqlparams;
        }
        /// <summary>
        /// 根据方法的参数获取sqlparameter
        /// </summary>
        /// <param name="method">方法对像</param>
        /// <param name="values">参数对应的值</param>
        /// <returns></returns>
        public static System.Data.SqlClient.SqlParameter[] GetParameterGenerator(System.Reflection.MethodInfo method, object[] values)
        {

            if (method == null)
            {
                method = (MethodInfo)new System.Diagnostics.StackTrace().GetFrame(1).GetMethod();
            }
            ParameterInfo[] param = method.GetParameters();
            SqlParameter[] sqlParam = new SqlParameter[values.Length];
            int count = 0;
            for (int i = 0; i < param.Length; i++)
            {
                if (Attribute.IsDefined(param[i], typeof(NoDataFiledAttribute)))
                {
                    continue;
                }
                DataFiledAttribute d = Attribute.GetCustomAttribute(param[i], typeof(DataFiledAttribute)) as DataFiledAttribute;
                SqlParameter sparam = null;
                if (d.FieldName.StartsWith("@"))
                {
                    sparam = new SqlParameter(d.FieldName, values[count]);
                }
                else
                {
                    sparam = new SqlParameter("@" + d.FieldName, values[count]);

                }
                sqlParam[count] = sparam;
                count++;
            }
            return sqlParam;
        }
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

    public class StringComparer : IEqualityComparer<string>
    {

        public bool Equals(string x, string y)
        {
            return x.ToLower() == y.ToLower();
        }
        public int GetHashCode(string obj)
        {
            throw new NotImplementedException();
        }
    }
}
