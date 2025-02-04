using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCMBKurBilgisCekme
{
    public class GetKur
    {
        public decimal[] GetKurList()
        {

            decimal[] array = new decimal[4];
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("https://www.tcmb.gov.tr/kurlar/today.xml");

            //Dolar için alanlar
            DataRow dataRow = dataSet.Tables[1].Rows[0];

            array[0] = Convert.ToDecimal(dataRow[3].ToString().Replace('.',',')); // Alış fiyatı 
            array[1] = Convert.ToDecimal(dataRow[4].ToString().Replace('.',',')); // Satış Fiyatı



            //Euro için
            dataRow = dataSet.Tables[1].Rows[3];
            array[2] = Convert.ToDecimal(dataRow[3].ToString().Replace('.',',')); // Alış fiyatı 
            array[3] = Convert.ToDecimal(dataRow[4].ToString().Replace('.',','));// Satış Fiyatı



            return array;

        }
    }
}
