namespace SmartSales_Api.Events
{
    public static class MethodGeneric
    {
        public static async Task<IResult> HandleSPRequest<T>(Func<Task<T>> spMethod)
        {
            try
            {
                var result = await spMethod();

                if (result == null)
                {
                    var errorResponse = new ErrorResponse("No data found.", 404);
                    return Results.NotFound(errorResponse);
                }

                return Results.Ok(result);
            }
            catch (Exception ex)
            {
                var errorResponse = new ErrorResponse(ex.Message, 500, ex.StackTrace);
                return Results.Problem(errorResponse.Message, statusCode: 500);
            }
        }
    }
}
