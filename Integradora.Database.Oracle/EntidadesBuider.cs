using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Xml.Serialization;
using System.Data;
using System.ComponentModel;
using System.Globalization;

namespace Integradora.Database.Oracle
{
    public class EntidadeBuider
    {
        public  TEntity CriarEntidadeNoDataRow<TEntity>(DataRow drData)
           where TEntity : class, new()
        {
           
            Attribute aTargetAttribute; 
            Type tColumnDataType;
            TEntity targetClass = new TEntity();
            Type targetType = targetClass.GetType();
                     
            PropertyInfo[] properties = targetType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            
            foreach (PropertyInfo piTargetProperty in properties)
            {
                aTargetAttribute = Attribute.GetCustomAttribute(piTargetProperty, typeof(XmlElementAttribute));
                if (aTargetAttribute != null)
                {
                    try
                    {
                        foreach (DataColumn column in drData.Table.Columns)
                        {
                            if (((XmlElementAttribute)aTargetAttribute).ElementName.ToUpper() == column.ColumnName.ToUpper())
                            {
                                if (drData[column.ToString()] != DBNull.Value)
                                {
                                    tColumnDataType = drData[column.ToString()].GetType();
                                    if ((tColumnDataType != null) && (tColumnDataType == typeof(System.String)) && (piTargetProperty.PropertyType.IsGenericType) && (piTargetProperty.PropertyType.GetGenericTypeDefinition().Equals(typeof(Nullable<>))) && ((new NullableConverter(piTargetProperty.PropertyType)).UnderlyingType == typeof(System.DateTime)))
                                    {
                                        DateTime dt = DateTime.ParseExact(drData[column.ToString()].ToString(), "dd-MMM-YY", CultureInfo.CurrentCulture);
                                        piTargetProperty.SetValue(targetClass, dt, null);
                                    }
                                    else
                                    {
                                        var aaaa = drData[column.ToString()];
                                        piTargetProperty.SetValue(targetClass, drData[column.ToString()], null);
                                    } break;
                                }
                            }
                        }
                    }
                    catch (Exception ex) { 
                        throw new ApplicationException(string.Format("Load Failure of the Attribute ({0}) for {1}. Exception:{2}", ((XmlElementAttribute)aTargetAttribute).ElementName, targetType.Name, ex.Message));
                    }
                }
            } 
            return targetClass;

        }
    }
}

