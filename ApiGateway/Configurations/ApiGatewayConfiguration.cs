using Yarp.ReverseProxy.Configuration;

namespace ApiGateway.Configurations
{
    public static class ApiGatewayConfiguration
    { 
        public static IReadOnlyList<RouteConfig> GetRoutes()
        {
            return new[]
            {
                // Products Endpoint
                // products route
                new RouteConfig
                {
                    RouteId = "products-route", // Unique identify for this route
                    ClusterId = "products-cluster", // This is the cluster ID to map the routes to
                    Match = new RouteMatch
                    {
                        Path = "/api/products/{**catch-all}" // URL path pattern for products route
                    }
                },

                // Orders Endpoint
                // orders route
                new RouteConfig
                {
                    RouteId = "orders-route", // Unique identifier for this route
                    ClusterId = "orders-cluster", // This is the cluster ID to map the routes to
                    Match = new RouteMatch
                    {
                        Path = "/api/orders/{**catch-all}" // URL path pattern for products route
                    }
                }
            };
        }

        public static IReadOnlyList<ClusterConfig> GetClusters()
        {
            return new[]
            {
                // Define the products cluster
                new ClusterConfig
                {
                    ClusterId = "products-cluster", // Unique cluster identifier
                    Destinations = new Dictionary<string, DestinationConfig>
                    {
                        {
                            "products-destination", new DestinationConfig 
                            {
                                Address = "http://localhost:5001"
                            }
                        }
                    }
                },

                // Define the oders cluster
                    new ClusterConfig
                    {
                        ClusterId = "orders-cluster", // Unique cluster identifier
                        Destinations = new Dictionary<string, DestinationConfig>
                        {
                            {
                                "orders-destination", new DestinationConfig 
                                {
                                    Address = "http://localhost:5002"
                                }
                            }
                        }
                    }
            };
        }
    }
}