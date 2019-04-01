using UnityEngine;
using System;
using System.Data;
using System.Collections;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.IO;
public class NewBehaviourScript : MonoBehaviour
{

    string Error = null;
    void Start()
    {
        try
        {
            SqlAccess sql = new SqlAccess();

            //創立資料庫//
            //// 使用CreateTableAutoID 建立一個名為MONO的TABLE , 當中包括"id","name","qq","email","blog" , 使用"int","text","text","text","text" 的TYPE
            //sql.CreateTableAutoID("momo", new string[] { "id", "name", "qq", "email", "blog" }, new string[] { "int", "text", "text", "text", "text" });
            ////sql.CreateTable("momo",new string[]{"name","qq","email","blog"}, new string[]{"text","text","text","text"});

            //在資料庫新增欄位//
            // 在MONO的TABLE中為"name","qq","email","blog" 加入 "xuanyusong","289187120","xuanyusong@gmail.com","xuanyusong.com" 的值
            //sql.InsertInto("momo", new string[] { "name", "qq", "email", "blog" }, new string[] { "xuanyusong", "289187120", "xuanyusong@gmail.com", "xuanyusong.com" });
            //// 在MONO的TABLE中為"name","qq","email","blog" 加入 "ruoruo","34546546","ruoruo@gmail.com","xuanyusong.com" 的值
            //sql.InsertInto("momo", new string[] { "name", "qq", "email", "blog" }, new string[] { "ruoruo", "34546546", "ruoruo@gmail.com", "xuanyusong.com" });

            //讀取資料庫的欄位//
            //  在MONO的TABLE中尋找 name 及 qq 的值 , 條件為ID 值 = 1的資料
            //DataSet ds = sql.SelectWhere("momo", new string[] { "name", "qq" }, new string[] { "id" }, new string[] { "=" }, new string[] { "1" });
            DataSet ds = sql.SelectWhere("quiz00", new string[] { "String_ID", "Name" }, new string[] { "ID" }, new string[] { "=" }, new string[] { "4" });
            if (ds != null)
            {

                DataTable table = ds.Tables[0];

                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        Debug.Log(row[column]);
                    }
                }
            }

            //讀取所有資料//
            //DataSet dsall = sql.SelectALLWhere("quiz00");
            //DataTable tableall = dsall.Tables[0];
            //Debug.Log(tableall.Rows.Count);

            //修改資料庫欄位//
            ////  更新MONO TABLE中 name,qq 的值為 "'ruoruo'","'11111111'" 條件為 email = xuanyusong@gmail.com 的資料
            //sql.UpdateInto("momo", new string[] { "name", "qq" }, new string[] { "'ruoruo'", "'11111111'" }, "email", "'xuanyusong@gmail.com'");

            //刪除資料庫欄位//
            ////  刪除MONO TABLE 中條件為 ID 是 1 , EMAIL 是000@gmail.com 的資料
            //sql.Delete("momo", new string[] { "id", "email" }, new string[] { "1", "'000@gmail.com'" });
            //sql.Close();

        }
        catch (Exception e)
        {
            Error = e.Message;
        }
    }

    // Update is called once per frame
    void OnGUI()
    {

        if (Error != null)
        {
            GUILayout.Label(Error);
        }

    }
}
