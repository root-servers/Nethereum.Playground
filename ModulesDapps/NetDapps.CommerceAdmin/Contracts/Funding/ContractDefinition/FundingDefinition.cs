using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace NetDapps.CommerceAdmin.Contracts.Funding.ContractDefinition
{


    public partial class FundingDeployment : FundingDeploymentBase
    {
        public FundingDeployment() : base(BYTECODE) { }
        public FundingDeployment(string byteCode) : base(byteCode) { }
    }

    public class FundingDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60806040526040516200158638038062001586833981016040819052620000269162000065565b600080546001600160a01b0390921661010002610100600160a81b0319909216919091179055620000ba565b80516200005f81620000a0565b92915050565b6000602082840312156200007857600080fd5b600062000086848462000052565b949350505050565b60006001600160a01b0382166200005f565b620000ab816200008e565b8114620000b757600080fd5b50565b6114bc80620000ca6000396000f3fe608060405234801561001057600080fd5b50600436106100cf5760003560e01c8063a03be9a91161008c578063d514685111610066578063d51468511461017c578063e7d8b8071461018f578063eddef45b146101a2578063f3ad65f4146101b5576100cf565b8063a03be9a91461013f578063ac764f2e14610147578063d010f01414610167576100cf565b806306ac2d3d146100d4578063289421ce146100e95780632d548dee146100fc5780634360beb5146101045780634ab2930a1461012257806364a2dcc91461012a575b600080fd5b6100e76100e2366004610f06565b6101bd565b005b6100e76100f7366004610fd7565b610408565b6100e7610602565b61010c610611565b604051610119919061125d565b60405180910390f35b61010c610620565b61013261062f565b60405161011991906111e9565b6100e761063e565b61015a610155366004610ea4565b61064a565b604051610119919061124f565b61016f6106cf565b6040516101199190611241565b61016f61018a366004610fd7565b6106d8565b6100e761019d366004610fd7565b6106de565b6100e76101b0366004610fd7565b6107d3565b61010c610ac0565b60005460405163d9c4c15360e01b81526101009091046001600160a01b03169063d9c4c153906101f190869060040161126b565b60206040518083038186803b15801561020957600080fd5b505afa15801561021d573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506102419190810190610eca565b600180546001600160a01b0319166001600160a01b039283161790819055166102855760405162461bcd60e51b815260040161027c9061130c565b60405180910390fd5b60005460405163d9c4c15360e01b81526101009091046001600160a01b03169063d9c4c153906102b990849060040161126b565b60206040518083038186803b1580156102d157600080fd5b505afa1580156102e5573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506103099190810190610eca565b600280546001600160a01b0319166001600160a01b039283161790819055166103445760405162461bcd60e51b815260040161027c906112ec565b60005460405163d9c4c15360e01b81526101009091046001600160a01b03169063d9c4c1539061037890859060040161126b565b60206040518083038186803b15801561039057600080fd5b505afa1580156103a4573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506103c89190810190610eca565b600380546001600160a01b0319166001600160a01b039283161790819055166104035760405162461bcd60e51b815260040161027c906112dc565b505050565b6003546001600160a01b031633146104325760405162461bcd60e51b815260040161027c906112fc565b61043a610bdb565b600154604051634339a73160e11b81526001600160a01b03909116906386734e629061046a90859060040161132c565b6102206040518083038186803b15801561048357600080fd5b505afa158015610497573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506104bb9190810190610f9a565b610140810151600254608083015160405163206d54db60e01b815293945091926000926001600160a01b039092169163206d54db916104fd919060040161124f565b60206040518083038186803b15801561051557600080fd5b505afa158015610529573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525061054d9190810190610eca565b61018084015160405163a9059cbb60e01b81529192506000916001600160a01b0385169163a9059cbb9161058591869160040161121f565b602060405180830381600087803b15801561059f57600080fd5b505af11580156105b3573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506105d79190810190610ee8565b90506001811515146105fb5760405162461bcd60e51b815260040161027c9061131c565b5050505050565b6000805460ff19166001179055565b6002546001600160a01b031681565b6001546001600160a01b031681565b6003546001600160a01b031681565b6000805460ff19169055565b6040516370a0823160e01b81526000906001600160a01b038316906370a08231906106799030906004016111e9565b60206040518083038186803b15801561069157600080fd5b505afa1580156106a5573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506106c99190810190610fb9565b92915050565b60005460ff1681565b50600190565b6003546001600160a01b031633146107085760405162461bcd60e51b815260040161027c906112fc565b610710610bdb565b600154604051634339a73160e11b81526001600160a01b03909116906386734e629061074090859060040161132c565b6102206040518083038186803b15801561075957600080fd5b505afa15801561076d573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506107919190810190610f9a565b610140810151600254602083015160405163206d54db60e01b815293945091926000926001600160a01b039092169163206d54db916104fd919060040161124f565b6003546001600160a01b031633146107fd5760405162461bcd60e51b815260040161027c906112fc565b61082860405180604001604052806009815260200168383790373ab6b132b960b91b81525082610ad4565b610830610bdb565b600154604051634339a73160e11b81526001600160a01b03909116906386734e629061086090859060040161132c565b6102206040518083038186803b15801561087957600080fd5b505afa15801561088d573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506108b19190810190610f9a565b610140810151600254602083015160405163206d54db60e01b815293945091926000926001600160a01b039092169163206d54db916108f3919060040161124f565b60206040518083038186803b15801561090b57600080fd5b505afa15801561091f573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506109439190810190610eca565b90506109746040518060400160405280600d81526020016c7472616e736665722066726f6d60981b81525082610b1d565b61099d6040518060400160405280600781526020016639b832b73232b960c91b81525030610b1d565b6109cf6040518060400160405280600b81526020016a746f74616c2076616c756560a81b815250846101800151610b59565b6101808301516040516323b872dd60e01b81526000916001600160a01b038516916323b872dd91610a0691869130916004016111f7565b602060405180830381600087803b158015610a2057600080fd5b505af1158015610a34573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250610a589190810190610ee8565b90508015610a9257610a8d6040518060400160405280600c81526020016b504f2066756e646564206f6b60a01b815250610b95565b6105fb565b6105fb6040518060400160405280600d81526020016c1413c81b9bdd08199d5b991959609a1b815250610b95565b60005461010090046001600160a01b031681565b60005460ff1615610b19577f01ce645dd4cd5b0725197394436a46a8a4055e2d5b629cc7d8e9f14df1515b8d8282604051610b109291906112bc565b60405180910390a15b5050565b60005460ff1615610b19577f6d82518c519b6cd311f41c64b27912b63453c12888e8c04d4f5b1e78703c2d228282604051610b1092919061127c565b60005460ff1615610b19577f4d4bb50ec644b1318885d0766dcba0a211c28f9855d6e924a632f37d8fc04d218282604051610b1092919061129c565b60005460ff1615610bd8577fa95e6e2a182411e7a6f9ed114a85c3761d87f9b8f453d842c71235aa64fff99f81604051610bcf919061126b565b60405180910390a15b50565b6040805161022081018252600080825260208201819052918101829052606081018290526080810182905260a0810182905260c0810182905260e08101829052610100810182905261012081018290526101408101829052610160810182905261018081018290526101a081018290526101c08101829052906101e082019081526020016000905290565b80356106c981611427565b80516106c981611427565b80516106c98161143b565b80516106c981611444565b80516106c98161144d565b80516106c98161145a565b600082601f830112610cb957600080fd5b8135610ccc610cc782611361565b61133a565b91508082526020830160208301858383011115610ce857600080fd5b610cf38382846113e1565b50505092915050565b60006102208284031215610d0f57600080fd5b610d1a61022061133a565b90506000610d288484610e99565b8252506020610d3984848301610c87565b6020830152506040610d4d84828501610c87565b6040830152506060610d6184828501610c87565b6060830152506080610d7584828501610c87565b60808301525060a0610d8984828501610c87565b60a08301525060c0610d9d84828501610c87565b60c08301525060e0610db184828501610c87565b60e083015250610100610dc684828501610c87565b61010083015250610120610ddc84828501610c87565b61012083015250610140610df284828501610c71565b61014083015250610160610e0884828501610e83565b61016083015250610180610e1e84828501610e83565b610180830152506101a0610e3484828501610e83565b6101a0830152506101c0610e4a84828501610e83565b6101c0830152506101e0610e6084828501610c92565b6101e083015250610200610e7684828501610c9d565b6102008301525092915050565b80516106c981611467565b80356106c981611470565b80516106c981611470565b600060208284031215610eb657600080fd5b6000610ec28484610c66565b949350505050565b600060208284031215610edc57600080fd5b6000610ec28484610c71565b600060208284031215610efa57600080fd5b6000610ec28484610c7c565b600080600060608486031215610f1b57600080fd5b833567ffffffffffffffff811115610f3257600080fd5b610f3e86828701610ca8565b935050602084013567ffffffffffffffff811115610f5b57600080fd5b610f6786828701610ca8565b925050604084013567ffffffffffffffff811115610f8457600080fd5b610f9086828701610ca8565b9150509250925092565b60006102208284031215610fad57600080fd5b6000610ec28484610cfc565b600060208284031215610fcb57600080fd5b6000610ec28484610c87565b600060208284031215610fe957600080fd5b6000610ec28484610e8e565b610ffe81611396565b82525050565b610ffe816113a1565b610ffe816113a6565b610ffe816113cb565b600061102a82611389565b611034818561138d565b93506110448185602086016113ed565b61104d8161141d565b9093019392505050565b600061106460298361138d565b7f436f756c64206e6f742066696e6420506f4d61696e206164647265737320696e81526820726567697374727960b81b602082015260400192915050565b60006110af60398361138d565b7f436f756c64206e6f742066696e6420427573696e657373506172746e6572537481527f6f72616765206164647265737320696e20726567697374727900000000000000602082015260400192915050565b600061110e60248361138d565b7f46756e6374696f6e206d7573742062652063616c6c65642066726f6d20504f2081526326b0b4b760e11b602082015260400192915050565b6000611154602c8361138d565b7f436f756c64206e6f742066696e6420506f53746f72616765206164647265737381526b20696e20726567697374727960a01b602082015260400192915050565b60006111a2601c8361138d565b7f4e6f7420656e6f7567682066756e6473207472616e7366657272656400000000815260200192915050565b610ffe816113d6565b610ffe816113b5565b610ffe816113be565b602081016106c98284610ff5565b606081016112058286610ff5565b6112126020830185610ff5565b610ec260408301846111ce565b6040810161122d8285610ff5565b61123a60208301846111ce565b9392505050565b602081016106c98284611004565b602081016106c9828461100d565b602081016106c98284611016565b6020808252810161123a818461101f565b6040808252810161128d818561101f565b905061123a6020830184610ff5565b604080825281016112ad818561101f565b905061123a60208301846111d7565b604080825281016112cd818561101f565b905061123a60208301846111e0565b602080825281016106c981611057565b602080825281016106c9816110a2565b602080825281016106c981611101565b602080825281016106c981611147565b602080825281016106c981611195565b602081016106c982846111e0565b60405181810167ffffffffffffffff8111828210171561135957600080fd5b604052919050565b600067ffffffffffffffff82111561137857600080fd5b506020601f91909101601f19160190565b5190565b90815260200190565b60006106c9826113a9565b151590565b90565b6001600160a01b031690565b63ffffffff1690565b67ffffffffffffffff1690565b60006106c982611396565b60006106c9826113b5565b82818337506000910152565b60005b838110156114085781810151838201526020016113f0565b83811115611417576000848401525b50505050565b601f01601f191690565b61143081611396565b8114610bd857600080fd5b611430816113a1565b611430816113a6565b60058110610bd857600080fd5b600e8110610bd857600080fd5b611430816113b5565b611430816113be56fea365627a7a723058202f72b0f691165ca8dd0db9987ecbc2a0593b0879963505a444cbe508f3ccfda56c6578706572696d656e74616cf564736f6c634300050a0040";
        public FundingDeploymentBase() : base(BYTECODE) { }
        public FundingDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "contractAddressOfRegistry", 1)]
        public virtual string ContractAddressOfRegistry { get; set; }
    }

    public partial class ConfigureFunction : ConfigureFunctionBase { }

    [Function("configure")]
    public class ConfigureFunctionBase : FunctionMessage
    {
        [Parameter("string", "nameOfPoStorage", 1)]
        public virtual string NameOfPoStorage { get; set; }
        [Parameter("string", "nameOfPoMain", 2)]
        public virtual string NameOfPoMain { get; set; }
        [Parameter("string", "nameOfBusinessPartnerStorage", 3)]
        public virtual string NameOfBusinessPartnerStorage { get; set; }
    }

    public partial class TransferOutFundsForPoToSellerFunction : TransferOutFundsForPoToSellerFunctionBase { }

    [Function("transferOutFundsForPoToSeller")]
    public class TransferOutFundsForPoToSellerFunctionBase : FunctionMessage
    {
        [Parameter("uint64", "poNumber", 1)]
        public virtual ulong PoNumber { get; set; }
    }

    public partial class SwitchDebugOnFunction : SwitchDebugOnFunctionBase { }

    [Function("switchDebugOn")]
    public class SwitchDebugOnFunctionBase : FunctionMessage
    {

    }

    public partial class BusinessPartnerStorageFunction : BusinessPartnerStorageFunctionBase { }

    [Function("businessPartnerStorage", "address")]
    public class BusinessPartnerStorageFunctionBase : FunctionMessage
    {

    }

    public partial class PoStorageFunction : PoStorageFunctionBase { }

    [Function("poStorage", "address")]
    public class PoStorageFunctionBase : FunctionMessage
    {

    }

    public partial class PoMainContractAddressFunction : PoMainContractAddressFunctionBase { }

    [Function("poMainContractAddress", "address")]
    public class PoMainContractAddressFunctionBase : FunctionMessage
    {

    }

    public partial class SwitchDebugOffFunction : SwitchDebugOffFunctionBase { }

    [Function("switchDebugOff")]
    public class SwitchDebugOffFunctionBase : FunctionMessage
    {

    }

    public partial class GetBalanceOfThisFunction : GetBalanceOfThisFunctionBase { }

    [Function("getBalanceOfThis", "uint256")]
    public class GetBalanceOfThisFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenAddress", 1)]
        public virtual string TokenAddress { get; set; }
    }

    public partial class IsDebugOnFunction : IsDebugOnFunctionBase { }

    [Function("isDebugOn", "bool")]
    public class IsDebugOnFunctionBase : FunctionMessage
    {

    }

    public partial class GetPoFundingStatusFunction : GetPoFundingStatusFunctionBase { }

    [Function("getPoFundingStatus", "bool")]
    public class GetPoFundingStatusFunctionBase : FunctionMessage
    {
        [Parameter("uint64", "poNumber", 1)]
        public virtual ulong PoNumber { get; set; }
    }

    public partial class TransferOutFundsForPoToBuyerFunction : TransferOutFundsForPoToBuyerFunctionBase { }

    [Function("transferOutFundsForPoToBuyer")]
    public class TransferOutFundsForPoToBuyerFunctionBase : FunctionMessage
    {
        [Parameter("uint64", "poNumber", 1)]
        public virtual ulong PoNumber { get; set; }
    }

    public partial class TransferInFundsForPoFromBuyerFunction : TransferInFundsForPoFromBuyerFunctionBase { }

    [Function("transferInFundsForPoFromBuyer")]
    public class TransferInFundsForPoFromBuyerFunctionBase : FunctionMessage
    {
        [Parameter("uint64", "poNumber", 1)]
        public virtual ulong PoNumber { get; set; }
    }

    public partial class AddressRegistryFunction : AddressRegistryFunctionBase { }

    [Function("addressRegistry", "address")]
    public class AddressRegistryFunctionBase : FunctionMessage
    {

    }

    public partial class LogStringEventDTO : LogStringEventDTOBase { }

    [Event("LogString")]
    public class LogStringEventDTOBase : IEventDTO
    {
        [Parameter("string", "message", 1, false )]
        public virtual string Message { get; set; }
    }

    public partial class LogAddrEventDTO : LogAddrEventDTOBase { }

    [Event("LogAddr")]
    public class LogAddrEventDTOBase : IEventDTO
    {
        [Parameter("string", "desc", 1, false )]
        public virtual string Desc { get; set; }
        [Parameter("address", "message", 2, false )]
        public virtual string Message { get; set; }
    }

    public partial class LogBytes32EventDTO : LogBytes32EventDTOBase { }

    [Event("LogBytes32")]
    public class LogBytes32EventDTOBase : IEventDTO
    {
        [Parameter("string", "desc", 1, false )]
        public virtual string Desc { get; set; }
        [Parameter("bytes32", "message", 2, false )]
        public virtual byte[] Message { get; set; }
    }

    public partial class LogUint64EventDTO : LogUint64EventDTOBase { }

    [Event("LogUint64")]
    public class LogUint64EventDTOBase : IEventDTO
    {
        [Parameter("string", "desc", 1, false )]
        public virtual string Desc { get; set; }
        [Parameter("uint64", "message", 2, false )]
        public virtual ulong Message { get; set; }
    }

    public partial class LogUint32EventDTO : LogUint32EventDTOBase { }

    [Event("LogUint32")]
    public class LogUint32EventDTOBase : IEventDTO
    {
        [Parameter("string", "desc", 1, false )]
        public virtual string Desc { get; set; }
        [Parameter("uint32", "message", 2, false )]
        public virtual uint Message { get; set; }
    }







    public partial class BusinessPartnerStorageOutputDTO : BusinessPartnerStorageOutputDTOBase { }

    [FunctionOutput]
    public class BusinessPartnerStorageOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PoStorageOutputDTO : PoStorageOutputDTOBase { }

    [FunctionOutput]
    public class PoStorageOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PoMainContractAddressOutputDTO : PoMainContractAddressOutputDTOBase { }

    [FunctionOutput]
    public class PoMainContractAddressOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class GetBalanceOfThisOutputDTO : GetBalanceOfThisOutputDTOBase { }

    [FunctionOutput]
    public class GetBalanceOfThisOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "balance", 1)]
        public virtual BigInteger Balance { get; set; }
    }

    public partial class IsDebugOnOutputDTO : IsDebugOnOutputDTOBase { }

    [FunctionOutput]
    public class IsDebugOnOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class GetPoFundingStatusOutputDTO : GetPoFundingStatusOutputDTOBase { }

    [FunctionOutput]
    public class GetPoFundingStatusOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "isFullyFunded", 1)]
        public virtual bool IsFullyFunded { get; set; }
    }





    public partial class AddressRegistryOutputDTO : AddressRegistryOutputDTOBase { }

    [FunctionOutput]
    public class AddressRegistryOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }
}
