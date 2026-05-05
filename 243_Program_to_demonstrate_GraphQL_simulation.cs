using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 243. Program to demonstrate GraphQL simulation
// Generated as a standalone sample file.
public class GraphQLQuery
{
    public string Query { get; set; }
}

public class GraphQLResponse
{
    public string Data { get; set; }
}

public class MockGraphQLServer
{
    public GraphQLResponse ExecuteQuery(GraphQLQuery query)
    {
        // Mock response
        return new GraphQLResponse { Data = "Mock GraphQL data for query: " + query.Query };
    }
}

public class Problem243
{
    public static async Task Main()
    {
        MockGraphQLServer server = new MockGraphQLServer();
        GraphQLQuery query = new GraphQLQuery { Query = "{ user { name } }" };
        GraphQLResponse response = server.ExecuteQuery(query);
        Console.WriteLine(response.Data);

        await Task.CompletedTask;
    }
}