﻿namespace BlogSystem.Web
{
    using System.Data.Entity;
    using Data;
    using Data.Migrations;

    public class DataConfig
    {
        public static void ConfigureDatabase()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }
    }
}