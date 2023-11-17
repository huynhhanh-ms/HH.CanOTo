// Decompiled with JetBrains decompiler
// Type: Xtra.ExcelImport.ExcelHelper
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Xtra.ExcelImport
{
  public class ExcelHelper
  {
    public List<string> GetSheet(string fileName, bool IsFirstRowAsColumnNames = true)
    {
      List<string> sheet = new List<string>();
      if (File.Exists(fileName))
      {
        using (FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read))
        {
          if (fileName.EndsWith("xlsx"))
          {
            using (IExcelDataReader openXmlReader = ExcelReaderFactory.CreateOpenXmlReader((Stream) fileStream))
            {
              openXmlReader.IsFirstRowAsColumnNames = IsFirstRowAsColumnNames;
              DataSet dataSet = openXmlReader.AsDataSet();
              if (dataSet.Tables.Count < 1)
                throw new Exception("Kiếm tra lại file excel, không có sheet nào hoặc cấu trúc file không đúng");
              foreach (object table in (InternalDataCollectionBase) dataSet.Tables)
                sheet.Add(((DataTable) table).TableName.ToString());
            }
          }
          else
          {
            using (IExcelDataReader binaryReader = ExcelReaderFactory.CreateBinaryReader((Stream) fileStream))
            {
              binaryReader.IsFirstRowAsColumnNames = IsFirstRowAsColumnNames;
              DataSet dataSet = binaryReader.AsDataSet();
              if (dataSet.Tables.Count < 1)
                throw new Exception("Kiếm tra lại file excel, không có sheet nào hoặc cấu trúc file không đúng");
              foreach (object table in (InternalDataCollectionBase) dataSet.Tables)
                sheet.Add(((DataTable) table).TableName.ToString());
            }
          }
        }
      }
      return sheet;
    }

    public List<string> GetAllColumn(
      string fileName,
      string SheetName,
      bool IsFirstRowAsColumnNames = true)
    {
      List<string> allColumn = new List<string>();
      if (File.Exists(fileName))
      {
        using (FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read))
        {
          if (fileName.EndsWith("xlsx"))
          {
            using (IExcelDataReader openXmlReader = ExcelReaderFactory.CreateOpenXmlReader((Stream) fileStream))
            {
              openXmlReader.IsFirstRowAsColumnNames = IsFirstRowAsColumnNames;
              DataTable table = openXmlReader.AsDataSet().Tables[SheetName];
              if (table.Columns.Count < 1)
                throw new Exception(string.Format("Kiếm tra lại file excel, sheet {0} không có cột nào hoặc cấu trúc file không đúng", (object) SheetName));
              foreach (object column in (InternalDataCollectionBase) table.Columns)
                allColumn.Add(((DataColumn) column).ColumnName.ToString());
            }
          }
          else
          {
            using (IExcelDataReader binaryReader = ExcelReaderFactory.CreateBinaryReader((Stream) fileStream))
            {
              binaryReader.IsFirstRowAsColumnNames = IsFirstRowAsColumnNames;
              DataTable table = binaryReader.AsDataSet().Tables[SheetName];
              if (table.Columns.Count < 1)
                throw new Exception(string.Format("Kiếm tra lại file excel, sheet {0} không có cột nào hoặc cấu trúc file không đúng", (object) SheetName));
              foreach (object column in (InternalDataCollectionBase) table.Columns)
                allColumn.Add(((DataColumn) column).ColumnName.ToString());
            }
          }
        }
      }
      return allColumn;
    }

    public DataTable GetTable(string fileName, string SheetName)
    {
      if (!File.Exists(fileName))
        return new DataTable();
      using (FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read))
      {
        if (fileName.EndsWith("xlsx"))
        {
          using (IExcelDataReader openXmlReader = ExcelReaderFactory.CreateOpenXmlReader((Stream) fileStream))
          {
            openXmlReader.IsFirstRowAsColumnNames = true;
            return openXmlReader.AsDataSet().Tables[SheetName];
          }
        }
        else
        {
          using (IExcelDataReader binaryReader = ExcelReaderFactory.CreateBinaryReader((Stream) fileStream))
          {
            binaryReader.IsFirstRowAsColumnNames = true;
            return binaryReader.AsDataSet().Tables[SheetName];
          }
        }
      }
    }
  }
}
