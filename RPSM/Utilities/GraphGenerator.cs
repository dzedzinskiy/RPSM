using GraphVizWrapper;
using GraphVizWrapper.Commands;
using GraphVizWrapper.Queries;

namespace RPSM.Utilities
{
    public class GraphGenerator
    {
        private readonly GraphGeneration _wrapper;
        public GraphGenerator()
        {
            var getStartProcessQuery = new GetStartProcessQuery();
            var getProcessStartInfoQuery = new GetProcessStartInfoQuery();
            var registerLayoutPluginCommand = new RegisterLayoutPluginCommand(getProcessStartInfoQuery, getStartProcessQuery);

            _wrapper = new GraphGeneration(getStartProcessQuery,
                                              getProcessStartInfoQuery,
                                              registerLayoutPluginCommand);
        }

        public byte[] GenerateGraph(string graphStr, Enums.GraphReturnType returnType)
        {
            return _wrapper.GenerateGraph(graphStr, returnType);
        }
    }
}
