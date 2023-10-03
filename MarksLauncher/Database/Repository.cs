using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using Dapper;
using MarksLaunchMenu.Dtos;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace MarksLaunchMenu.Database
{
    internal class Repository
    {

        public static string DbFile = ""; 

        public static List<LinkDto> GetLinksForGroup(string groupId)
        {
            var sql = "";
            sql += "SELECT gl.LinkID,               ";
            sql += "        l.LinkName,             ";
            sql += "        l.LinkPath,              ";
            sql += "       gl.[Order]              ";
            sql += "  FROM GroupLinks gl             ";
            sql += "  JOIN Links      l              ";
            sql += "    ON gl.LinkId = l.LinkId   ";
            sql += " WHERE gl.GroupID = @gid        ";
            sql += " ORDER BY [Order]            ";

            var result = RunSql<LinkDto>(sql, new { gid = groupId });

            return result;


        }

        public static string AddGroup(string groupName)
        {

            var id = Guid.NewGuid().ToString();

            var sql = "";
            sql += "INSERT INTO Groups ";
            sql += "(GroupId, GroupName) ";
            sql += "VALUES ";
            sql += "(@id, @name)";

            ExecuteSql(sql, new { id, name = groupName });

            return id;

        }

        public static List<GroupDto> GetAllGroups()
        {
            var sql = "";
            sql += " SELECT GroupId,  ";
            sql += "        GroupName  ";
            sql += "  FROM Groups ";

            var result = RunSql<GroupDto>(sql);

            return result;
        }

        internal static void RenameGroup(string groupID, string newName)
        {
            var sql = "";
            sql += "UPDATE Groups ";
            sql += "   SET GroupName = @name ";
            sql += " WHERE GroupId = @gid";

            ExecuteSql(sql, new { gid = groupID, name = newName });
        }

        internal static void DeleteGroup(string groupID)
        {
            var sql = "";
            sql += " DELETE From Groups     ";
            sql += "  WHERE GroupId = @gid    ";
            sql += "      ";
            sql += "      ";

            ExecuteSql(sql, new { gid = groupID });
        }


        internal static void AddAndGroupLink(string groupId, string linkName, string linkPath)
        {
            var linkId = AddLink(linkName, linkPath);

            AddLinkToGroup(groupId, linkId);

        }

        private static void AddLinkToGroup(string groupId, string linkId)
        {

            var nextOrderNumber = GetNextOrderNumber(groupId); 

            var sql = "";
            sql += "Insert Into ";
            sql += " GroupLinks (LinkId, GroupId, [Order])";
            sql += "VALUES  (";
            sql += "@lid, @gid, @ord)";

            ExecuteSql(sql, new { lid = linkId, gid = groupId, ord = nextOrderNumber });
        }

        private static int GetNextOrderNumber(string groupId)
        {

            var sql = "";
            sql += "select max([order]) as max "; 
            sql += "from GroupLinks "; 
            sql += "where GroupId = @gid"; 
            sql += "";

            var result = RunSql<int>(sql, new { gid = groupId });

            var number = result.FirstOrDefault();

            return number + 1;
        }

        public static string AddLink(string linkName, string linkPath)
        {

            var sql = "";
            sql += "Insert Into ";
            sql += " Links (LinkId, LinkName, LinkPath)";
            sql += "VALUES  (";
            sql += "@lid, @name, @path)";

            var linkId = Guid.NewGuid().ToString();

            ExecuteSql(sql, new { lid = linkId, name = linkName, path = linkPath });

            return linkId;

        }






        public static int ExecuteSql(string sql, object parameters)
        {
            using var cnn = new SQLiteConnection("Data source=" + DbFile);
            cnn.Open();

            var result = cnn.Execute(sql, parameters);

            cnn.Close();

            return result;
        }

        public static List<T> RunSql<T>(string sql)
        {
            using var cnn = new SQLiteConnection("Data source=" + DbFile);
            cnn.Open();

            var result = cnn.Query<T>(sql);

            cnn.Close();

            return result.ToList();
        }

        public static List<T> RunSql<T>(string sql, object parameters)
        {
            using var cnn = new SQLiteConnection("Data source=" + DbFile);
            cnn.Open();

            var result = cnn.Query<T>(sql, parameters);

            cnn.Close();

            return result.ToList();
        }

        

        public static bool DoesDatabaseExist()
        {
            if (!Directory.Exists(GlobalSettings.UserDataFolder))
                return false;

            if (File.Exists(GlobalSettings.DatabaseFileName))
                return true;
            return false;
        }

        public static void CreateDatabase()
        {

            if (!Directory.Exists(GlobalSettings.UserDataFolder))
                Directory.CreateDirectory(GlobalSettings.UserDataFolder);

            // Copy starter database 
            var resources = Assembly.GetExecutingAssembly().GetManifestResourceNames();

            var embeddedDatabaseName = "MarksLauncher.Database.starter.sqlite";
            if (resources.Contains(embeddedDatabaseName))
            {
                var outputFile = Path.GetTempFileName();

                if (File.Exists(outputFile))
                    File.Delete(outputFile);

                using var resourceStream = Assembly.GetEntryAssembly().GetManifestResourceStream(embeddedDatabaseName);
                using var outputStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write);
                resourceStream.CopyTo(outputStream);

                File.Copy(outputFile, GlobalSettings.DatabaseFileName);
            }
        }

        internal static int GetForeColor()
        {
            var sql = "";
            sql += " SELECT Value  ";
            sql += "   FROM Settings ";
            sql += "  WHERE Key = 'ForeColor' ";

            var result = RunSql<string>(sql);

            return int.Parse(result.First()); 
        }

        internal static void SetForeColor(Color foreColor)
        {

            var foreString = foreColor.ToArgb().ToString();

            var sql = "";
            sql += "UPDATE Settings ";
            sql += "   SET Value = @fore ";
            sql += " WHERE Key = 'ForeColor' ";

            ExecuteSql(sql, new { fore = foreString });
        }

        internal static string GetBackColor()
        {
            var sql = "";
            sql += " SELECT Value  ";
            sql += "   FROM Settings ";
            sql += "  WHERE Key = 'BackColor' ";

            var result = RunSql<string>(sql);

            return result.FirstOrDefault();
        }

        internal static void SetBackColor(Color backColor)
        {

            var backString = backColor.Name;

            var sql = "";
            sql += "UPDATE Settings ";
            sql += "   SET Value = @fore ";
            sql += " WHERE Key = 'BackColor' ";

            ExecuteSql(sql, new { fore = backString });
        }
        
   
        internal static void UpdateSort(string groupId, string linkId, int order)
        {
            var sql = "";
            sql += "Update GroupLinks "; 
            sql += "   SET [Order] = @ord  "; 
            sql += " WHERE GroupId = @gid  "; 
            sql += "   AND LinkId  = @lid  ";

            ExecuteSql(sql, new { ord = order, gid = groupId, lid = linkId });

        }

        internal static void UpdateLink(string linkId, string name, string linkPath)
        {
            var sql = "";
            sql += "UPDATE Links ";
            sql += "   SET LinkName = @nme, ";
            sql += "       LinkPath = @lp  ";
            sql += " WHERE LinkId   = @lid";

            ExecuteSql(sql, new { nme = name, lp = linkPath, lid = linkId });
        }

        internal static void DeleteLink(string linkId)
        {
            var sql = "";
            sql += "DELETE FROM GroupLinks ";
            sql += " WHERE LinkId = @lid;  ";
            sql += "DELETE FROM Links      ";
            sql += " WHERE LinkId = @lid;  ";

            ExecuteSql(sql, new {lid = linkId});
        }
    }
}
