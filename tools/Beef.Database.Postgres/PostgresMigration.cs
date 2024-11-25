﻿// Copyright (c) Avanade. Licensed under the MIT License. See https://github.com/Avanade/Beef

using DbEx;
using OnRamp;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Beef.Database.Postgres
{
    /// <summary>
    /// Provides the <see href="https://www.npgsql.org/">PostgreSQL</see> migration orchestration extending <see cref="DbEx.Postgres.Migration.PostgresMigration"/> to further enable <see cref="MigrationCommand.CodeGen"/>.
    /// </summary>
    public class PostgresMigration : DbEx.Postgres.Migration.PostgresMigration
    {
        /// <summary>
        /// Initializes an instance of the <see cref="PostgresMigration"/> class.
        /// </summary>
        /// <param name="args">The <see cref="MigrationArgs"/>.</param>
        public PostgresMigration(MigrationArgs args) : base(args) => IsCodeGenEnabled = true;

        /// <summary>
        /// Gets the <see cref="MigrationArgs"/>.
        /// </summary>
        public new MigrationArgs Args => (MigrationArgs)base.Args;

        /// <inheritdoc/>
        protected override Task<(bool Success, string? Statistics)> DatabaseCodeGenAsync(CancellationToken cancellationToken = default)
        {
            var yaml = Args.GetParameter<string>("Param0");
            if (yaml is null)
                return this.ExecuteCodeGenAsync(cancellationToken);

            var schema = Args.GetParameter<string>("Param1");
            var tables = new List<string>();
            for (int i = 2; true; i++)
            {
                var table = Args.GetParameter<string>($"Param{i}");
                if (table is null)
                    break;

                tables.Add(table);
            }

            if (schema is null || tables.Count == 0)
                throw new CodeGenException($"A '{nameof(MigrationCommand.CodeGen)}' command for 'YAML' also requires schema and at least one table argument to be specified.");

            return this.ExecuteYamlCodeGenAsync(schema, [.. tables], cancellationToken);
        }
    }
}