namespace SendPulse.Identity;

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using SendPulse.Identity.ClaimTypes;
using Dgmjr.Primitives.EntityFrameworkCore;
using Dgmjr.EntityFrameworkCore.Migrations;
using Dgmjr.EntityFrameworkCore.Constants;

public static class SendPulseIdEfCoreExtensions
{
    public static PropertyBuilder<ObjectId> SendPulseIdProperty<TEntity>(
        this EntityTypeBuilder<TEntity> entityBuilder,
        Expression<Func<TEntity, ObjectId>> propertyExpression,
        string validationFunctionSchemaName = DboSchema.ShortName,
        string validationFunctionName = FunctionNames.IsValidObjectId
    )
        where TEntity : class
    {
        entityBuilder.HasCheckConstraint(
            ck_ + entityBuilder.Property(propertyExpression).Metadata.GetColumnName(),
            $"[{validationFunctionSchemaName}].[{validationFunctionName}]([{entityBuilder.Property(propertyExpression).Metadata.GetColumnName()}])"
        );
        return entityBuilder
            .Property(propertyExpression)
            .HasConversion(new RegexValueObjectEfCoreConverter<ObjectId>())
            .HasMaxLength(ObjectId.Length)
            .IsUnicode(false);
    }

    public static PropertyBuilder<ObjectId> SendPulseIdProperty<TEntity>(
        this ModelBuilder modelBuilder,
        Expression<Func<TEntity, ObjectId>> propertyExpression
    )
        where TEntity : class =>
        modelBuilder.Entity<TEntity>().SendPulseIdProperty(propertyExpression);

    public static MigrationBuilder HasGetSendPulseIdFunction(
        this MigrationBuilder migrationBuilder
    ) => migrationBuilder.HasGetSendPulseIdFunction(ufn_ + Constants.GetSendPulseId);

    public static MigrationBuilder HasGetSendPulseIdFunction(
        this MigrationBuilder migrationBuilder,
        string functionName
    ) => migrationBuilder.HasGetSendPulseIdFunction(DboSchema.ShortName, functionName);

    public static MigrationBuilder HasGetSendPulseIdFunction(
        this MigrationBuilder migrationBuilder,
        string schema,
        string functionName
    )
    {
        migrationBuilder.Operations.Add(
            new CreateFunctionOperation(
                schema,
                functionName,
                "@userId nvarchar(MAX)",
                """
                RETURN
                (SELECT TOP 1 [Value]
                FROM [id].[tbl_UserClaim]
                WHERE [UserId] = @userId
                AND [Type] = 'https://sendpulse.com/identity/object_id');
                """
            )
        );
        return migrationBuilder;
    }

    public static MigrationBuilder RollBackGetSendPulseIdFunction(
        this MigrationBuilder migrationBuilder
    ) => migrationBuilder.RollBackGetSendPulseIdFunction(ufn_ + Constants.GetSendPulseId);

    public static MigrationBuilder RollBackGetSendPulseIdFunction(
        this MigrationBuilder migrationBuilder,
        string functionName
    ) => migrationBuilder.RollBackGetSendPulseIdFunction(DboSchema.ShortName, functionName);

    public static MigrationBuilder RollBackGetSendPulseIdFunction(
        this MigrationBuilder migrationBuilder,
        string schema,
        string functionName
    )
    {
        migrationBuilder.Operations.Add(new DropFunctionOperation(schema, functionName));
        return migrationBuilder;
    }
}
