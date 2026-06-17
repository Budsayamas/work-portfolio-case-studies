using System.Data;
using Microsoft.Data.SqlClient;

namespace PortfolioSamples.EyesightRecords;

public sealed class EmployeeRecordService
{
    private readonly string _connectionString;

    public EmployeeRecordService(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<bool> SaveEyesightRecordAsync(
        string employeeCode,
        int lineId,
        int shiftPeriodId,
        string result,
        CancellationToken cancellationToken = default)
    {
        const string sql = """
            INSERT INTO EmployeeEyesightRecords
                (EmployeeCode, LineId, ShiftPeriodId, Result, RecordedAt)
            VALUES
                (@employeeCode, @lineId, @shiftPeriodId, @result, @recordedAt);
            """;

        await using var connection = new SqlConnection(_connectionString);
        await using var command = new SqlCommand(sql, connection);

        command.Parameters.Add("@employeeCode", SqlDbType.VarChar, 20).Value = employeeCode;
        command.Parameters.Add("@lineId", SqlDbType.Int).Value = lineId;
        command.Parameters.Add("@shiftPeriodId", SqlDbType.Int).Value = shiftPeriodId;
        command.Parameters.Add("@result", SqlDbType.VarChar, 50).Value = result;
        command.Parameters.Add("@recordedAt", SqlDbType.DateTime2).Value = DateTime.UtcNow;

        await connection.OpenAsync(cancellationToken);
        return await command.ExecuteNonQueryAsync(cancellationToken) == 1;
    }
}
