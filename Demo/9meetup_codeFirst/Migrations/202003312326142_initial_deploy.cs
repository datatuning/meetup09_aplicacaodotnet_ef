﻿namespace _9meetup_codeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_deploy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CpfCnpj = c.String(),
                        DataCadastro = c.DateTime(nullable: false),
                        LimiteCredito = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
