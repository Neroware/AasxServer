using System.Collections.Generic;
using System.IO;
using AdminShellNS.Models;

namespace AasxServerStandardBib.Interfaces
{
    public interface ISubmodelService
    {
        ISubmodel CreateSubmodel(ISubmodel newSubmodel, string aasIdentifier);
        ISubmodelElement CreateSubmodelElement(string submodelIdentifier, ISubmodelElement newSubmodelElement, bool first);
        ISubmodelElement CreateSubmodelElementByPath(string submodelIdentifier, string idShortPath, bool first, ISubmodelElement newSubmodelElement);
        void DeleteFileByPath(string submodelIdentifier, string idShortPath);
        void DeleteSubmodelById(string submodelIdentifier);
        void DeleteSubmodelElementByPath(string submodelIdentifier, string idShortPath);
        List<ISubmodelElement> GetAllSubmodelElements(string submodelIdentifier);
        List<ISubmodel> GetAllSubmodels(IReference reqSemanticId = null, string idShort = null);
        string GetFileByPath(string submodelIdentifier, string idShortPath, out byte[] byteArray, out long fileSize);
        ISubmodel GetSubmodelById(string submodelIdentifier);
        ISubmodelElement GetSubmodelElementByPath(string submodelIdentifier, string idShortPath);
        bool IsSubmodelElementPresent(string submodelIdentifier, string idShortPath);
        void ReplaceFileByPath(string submodelIdentifier, string idShortPath, string fileName, string contentType, MemoryStream fileContent);
        void ReplaceSubmodelById(string submodelIdentifier, ISubmodel newSubmodel);
        void ReplaceSubmodelElementByPath(string submodelIdentifier, string idShortPath, ISubmodelElement newSme);
        void UpdateSubmodelById(string submodelIdentifier, ISubmodel newSubmodel);
        void UpdateSubmodelElementByPath(string submodelIdentifier, string idShortPath, ISubmodelElement newSme);
        OperationResult InvokeOperationSync(string submodelIdentifier, string idShortPath, List<OperationVariable> inputArguments, List<OperationVariable> inoutputArguments, int? timestamp, string requestId);
        OperationHandle InvokeOperationAsync(string submodelIdentifier, string idShortPath, List<OperationVariable> inputArguments, List<OperationVariable> inoutputArguments, int? timestamp, string requestId);
        OperationResult GetOperationAsyncResult(string handleId);
    }
}
