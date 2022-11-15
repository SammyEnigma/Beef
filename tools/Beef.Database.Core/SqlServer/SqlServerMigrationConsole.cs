﻿// Copyright (c) Avanade. Licensed under the MIT License. See https://github.com/Avanade/Beef

using DbEx.Migration;
using System;
using System.Reflection;

namespace Beef.Database.Core.SqlServer
{
    /// <summary>
    /// Provides the SQL Server migration console capability.
    /// </summary>
    public class SqlServerMigrationConsole : MigrationConsoleBase<SqlServerMigrationConsole>
    {
        /// <summary>
        /// Creates a new <see cref="SqlServerMigrationConsole"/> using <typeparamref name="T"/> to default the probing <see cref="Assembly"/>.
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/>.</typeparam>
        /// <param name="connectionString">The database connection string.</param>
        /// <returns>A new <see cref="SqlServerMigrationConsole"/>.</returns>
        public static SqlServerMigrationConsole Create<T>(string connectionString) => new(new MigrationArgs { ConnectionString = connectionString }.AddAssembly(typeof(T).Assembly));

        /// <summary>
        /// Creates a new instance of the <see cref="SqlServerMigrationConsole"/> class using the specified parameters.
        /// </summary>
        /// <param name="connectionString">The default connection string.</param>
        /// <param name="company">The company name.</param>
        /// <param name="appName">The application/domain name.</param>
        /// <param name="useBeefSchema">Indicates whether to use the standard <i>Beef</i> schema objects (defaults to <c>true</c>).</param>
        /// <returns>The <see cref="SqlServerMigrationConsole"/> instance.</returns>
        public static SqlServerMigrationConsole Create(string connectionString, string company, string appName, bool useBeefSchema = true)
            => new(new MigrationArgs { ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString)), UseBeefSchema = useBeefSchema }
                .AddParameter(CodeGen.CodeGenConsole.CompanyParamName, company ?? throw new ArgumentNullException(nameof(company)))
                .AddParameter(CodeGen.CodeGenConsole.AppNameParamName, appName ?? throw new ArgumentNullException(nameof(appName)))
                .AddAssembly(System.Reflection.Assembly.GetEntryAssembly()!));

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServerMigrationConsole"/> class.
        /// </summary>
        /// <param name="args">The default <see cref="MigrationArgs"/> that will be overridden/updated by the command-line argument values.</param>
        public SqlServerMigrationConsole(MigrationArgs? args = null) : base(args) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServerMigrationConsole"/> class that provides a default for the <paramref name="connectionString"/>.
        /// </summary>
        /// <param name="connectionString">The database connection string.</param>
        public SqlServerMigrationConsole(string connectionString) : this(new MigrationArgs { ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString)) }) { }

        /// <inheritdoc/>
        protected override DatabaseMigrationBase CreateMigrator() => new SqlServerMigration(Args);
    }
}