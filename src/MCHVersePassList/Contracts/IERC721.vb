Imports Nethereum.Web3
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports Nethereum.Contracts.CQS
Imports Nethereum.Util
Imports Nethereum.Web3.Accounts
Imports Nethereum.Hex.HexConvertors.Extensions
Imports Nethereum.Contracts
Imports Nethereum.Contracts.Extensions
Imports System
Imports System.Numerics
Imports System.Threading
Imports System.Threading.Tasks

Module IERC721

    '<[Function]("totalSupply", "uint256")>
    'Public Class TotalSupplyOfFunction
    '    Inherits FunctionMessage

    'End Class

    <[Function]("balanceOf", "uint256")>
    Public Class BalanceOfFunction
        Inherits FunctionMessage

        <Parameter("address", "owner", 1)>
        Public Property owner As String

    End Class

    <[Function]("ownerOf", "address")>
    Public Class OwnerOfFunction
        Inherits FunctionMessage

        <Parameter("uint256", "tokenId", 1)>
        Public Property tokenId As Integer

    End Class

    <[Function]("safeTransferFrom")>
    Public Class SafeTransferFromFunction
        Inherits FunctionMessage

        <Parameter("address", "from", 1)>
        Public Property from As String

        <Parameter("address", "to", 2)>
        Public Property [to] As String

        <Parameter("uint256", "tokenId", 3)>
        Public Property tokenId As Integer

    End Class

    <[Function]("transferFrom")>
    Public Class TransferFromFunction
        Inherits FunctionMessage

        <Parameter("address", "from", 1)>
        Public Property from As String

        <Parameter("address", "to", 2)>
        Public Property [to] As String

        <Parameter("uint256", "tokenId", 3)>
        Public Property tokenId As Integer

    End Class

    <[Function]("approve")>
    Public Class ApproveFunction
        Inherits FunctionMessage

        <Parameter("address", "to", 1)>
        Public Property [to] As String

        <Parameter("uint256", "tokenId", 2)>
        Public Property tokenId As Integer

    End Class

    <[Function]("getApproved", "address")>
    Public Class GetApproveFunction
        Inherits FunctionMessage

        <Parameter("uint256", "tokenId", 1)>
        Public Property tokenId As Integer

    End Class

    <[Function]("setApprovalForAll")>
    Public Class SetApprovalForAllFunction
        Inherits FunctionMessage

        <Parameter("address", "Operator", 1)>
        Public Property [Operator] As String

        <Parameter("boolean", "_approved", 2)>
        Public Property approved As Boolean

    End Class

    <[Function]("isApprovedForAll", "boolean")>
    Public Class IsApprovedForAllFunction
        Inherits FunctionMessage

        <Parameter("address", "owner", 1)>
        Public Property owner As String

        <Parameter("address", "Operator", 2)>
        Public Property [Operator] As String

    End Class

End Module
