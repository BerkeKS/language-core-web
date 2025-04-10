using System;

public class PCK_UNITS : OracleCommonManager
{
	private const string packageName = "PCK_UNITS";
	public PCK_UNITS(string ConnectionString) : base (ConnectionString) { }
    public PCK_UNITS(IDbConnection dbConnection) : base(dbConnection) { }
    public PCK_UNITS(IDbConnection dbConnection, bool connectionControlManual) : base(ConnectionString, connectionControlManual) { }
    public PCK_UNITS(ConnectionTypes connectionTypes) : base(connectionTypes) { }

    public DataTable Get_Units(decimal punit_number)
    {
        List<Parameter> parameterList = new List<Parameter>();
        parameterList.Add(new Parameter {Name = "PFNCRESULT", Direction=ParameterDirection.ReturnValue, Value = null, ParamType = ParamTypes.tRefCursor, UdtName = string.Empty});
        string procedureName = string.Format("{0}.{1}", packageName, "Get_Units");
        this.ExecuteStoredProcedure(parameterList, ref parameterList);
        return (DataTable)parameterList.First(object => object.Name == "PFNCRESULT").Value;
    }
}
