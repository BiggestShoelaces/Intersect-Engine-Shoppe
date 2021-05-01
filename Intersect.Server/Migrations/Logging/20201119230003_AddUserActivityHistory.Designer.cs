﻿// <auto-generated />
using System;
using Intersect.Server.Database.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Intersect.Server.Migrations.Logging
{
    [DbContext( typeof( LoggingContext ) )]
    [Migration( "20201119230003_AddUserActivityHistory" )]
    partial class AddUserActivityHistory
    {
        protected override void BuildTargetModel( ModelBuilder modelBuilder )
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation( "ProductVersion", "2.1.3-rtm-32065" );

            modelBuilder.Entity( "Intersect.Server.Database.Logging.Entities.UserActivityHistory", b =>
                 {
                     b.Property<Guid>( "Id" )
                         .ValueGeneratedOnAdd();

                     b.Property<int>( "Action" );

                     b.Property<string>( "Ip" );

                     b.Property<string>( "Meta" );

                     b.Property<int>( "Peer" );

                     b.Property<Guid?>( "PlayerId" );

                     b.Property<DateTime>( "TimeStamp" );

                     b.Property<Guid>( "UserId" );

                     b.HasKey( "Id" );

                     b.ToTable( "UserActivityHistory" );
                 } );

            modelBuilder.Entity( "Intersect.Server.Database.Logging.RequestLog", b =>
                 {
                     b.Property<Guid>( "Id" )
                         .ValueGeneratedOnAdd();

                     b.Property<byte>( "Level" );

                     b.Property<string>( "Method" );

                     b.Property<string>( "SerializedRequestHeaders" )
                         .HasColumnName( "RequestHeaders" );

                     b.Property<string>( "SerializedResponseHeaders" )
                         .HasColumnName( "ResponseHeaders" );

                     b.Property<int>( "StatusCode" );

                     b.Property<string>( "StatusMessage" );

                     b.Property<DateTime>( "Time" );

                     b.Property<string>( "Uri" );

                     b.HasKey( "Id" );

                     b.ToTable( "RequestLogs" );
                 } );
#pragma warning restore 612, 618
        }
    }
}
