using ServiceStack;
using CustomErrorHandlerTest.ServiceModel;

namespace CustomErrorHandlerTest.ServiceInterface
{
    [Route("/throw404")]
    public class Throw404 { }

    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }

        public object Any(Throw404 request)
        {
            throw HttpError.NotFound("Not here");
        }
    }
}
