using PayPal.Authentication;
using PayPal.PayPalAPIInterfaceService.Model;

namespace PayPal.PayPalAPIInterfaceService
{
    public interface IPayPalAPIInterfaceServiceService
    {
        /// <summary>
        /// 
        /// </summary>
        ///<param name="refundTransactionReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        RefundTransactionResponseType RefundTransaction(RefundTransactionReq refundTransactionReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="refundTransactionReq"></param>
        RefundTransactionResponseType RefundTransaction(RefundTransactionReq refundTransactionReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="refundTransactionReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        RefundTransactionResponseType RefundTransaction(RefundTransactionReq refundTransactionReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="initiateRecoupReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        InitiateRecoupResponseType InitiateRecoup(InitiateRecoupReq initiateRecoupReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="initiateRecoupReq"></param>
        InitiateRecoupResponseType InitiateRecoup(InitiateRecoupReq initiateRecoupReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="initiateRecoupReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        InitiateRecoupResponseType InitiateRecoup(InitiateRecoupReq initiateRecoupReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="completeRecoupReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        CompleteRecoupResponseType CompleteRecoup(CompleteRecoupReq completeRecoupReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="completeRecoupReq"></param>
        CompleteRecoupResponseType CompleteRecoup(CompleteRecoupReq completeRecoupReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="completeRecoupReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        CompleteRecoupResponseType CompleteRecoup(CompleteRecoupReq completeRecoupReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="cancelRecoupReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        CancelRecoupResponseType CancelRecoup(CancelRecoupReq cancelRecoupReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="cancelRecoupReq"></param>
        CancelRecoupResponseType CancelRecoup(CancelRecoupReq cancelRecoupReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="cancelRecoupReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        CancelRecoupResponseType CancelRecoup(CancelRecoupReq cancelRecoupReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getTransactionDetailsReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        GetTransactionDetailsResponseType GetTransactionDetails(GetTransactionDetailsReq getTransactionDetailsReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="getTransactionDetailsReq"></param>
        GetTransactionDetailsResponseType GetTransactionDetails(GetTransactionDetailsReq getTransactionDetailsReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getTransactionDetailsReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        GetTransactionDetailsResponseType GetTransactionDetails(GetTransactionDetailsReq getTransactionDetailsReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="billUserReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        BillUserResponseType BillUser(BillUserReq billUserReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="billUserReq"></param>
        BillUserResponseType BillUser(BillUserReq billUserReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="billUserReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        BillUserResponseType BillUser(BillUserReq billUserReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="transactionSearchReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        TransactionSearchResponseType TransactionSearch(TransactionSearchReq transactionSearchReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="transactionSearchReq"></param>
        TransactionSearchResponseType TransactionSearch(TransactionSearchReq transactionSearchReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="transactionSearchReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        TransactionSearchResponseType TransactionSearch(TransactionSearchReq transactionSearchReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="massPayReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        MassPayResponseType MassPay(MassPayReq massPayReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="massPayReq"></param>
        MassPayResponseType MassPay(MassPayReq massPayReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="massPayReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        MassPayResponseType MassPay(MassPayReq massPayReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="billAgreementUpdateReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        BAUpdateResponseType BillAgreementUpdate(BillAgreementUpdateReq billAgreementUpdateReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="billAgreementUpdateReq"></param>
        BAUpdateResponseType BillAgreementUpdate(BillAgreementUpdateReq billAgreementUpdateReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="billAgreementUpdateReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        BAUpdateResponseType BillAgreementUpdate(BillAgreementUpdateReq billAgreementUpdateReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="addressVerifyReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        AddressVerifyResponseType AddressVerify(AddressVerifyReq addressVerifyReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="addressVerifyReq"></param>
        AddressVerifyResponseType AddressVerify(AddressVerifyReq addressVerifyReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="addressVerifyReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        AddressVerifyResponseType AddressVerify(AddressVerifyReq addressVerifyReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="enterBoardingReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        EnterBoardingResponseType EnterBoarding(EnterBoardingReq enterBoardingReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="enterBoardingReq"></param>
        EnterBoardingResponseType EnterBoarding(EnterBoardingReq enterBoardingReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="enterBoardingReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        EnterBoardingResponseType EnterBoarding(EnterBoardingReq enterBoardingReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getBoardingDetailsReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        GetBoardingDetailsResponseType GetBoardingDetails(GetBoardingDetailsReq getBoardingDetailsReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="getBoardingDetailsReq"></param>
        GetBoardingDetailsResponseType GetBoardingDetails(GetBoardingDetailsReq getBoardingDetailsReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getBoardingDetailsReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        GetBoardingDetailsResponseType GetBoardingDetails(GetBoardingDetailsReq getBoardingDetailsReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="createMobilePaymentReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        CreateMobilePaymentResponseType CreateMobilePayment(CreateMobilePaymentReq createMobilePaymentReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="createMobilePaymentReq"></param>
        CreateMobilePaymentResponseType CreateMobilePayment(CreateMobilePaymentReq createMobilePaymentReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="createMobilePaymentReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        CreateMobilePaymentResponseType CreateMobilePayment(CreateMobilePaymentReq createMobilePaymentReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getMobileStatusReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        GetMobileStatusResponseType GetMobileStatus(GetMobileStatusReq getMobileStatusReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="getMobileStatusReq"></param>
        GetMobileStatusResponseType GetMobileStatus(GetMobileStatusReq getMobileStatusReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getMobileStatusReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        GetMobileStatusResponseType GetMobileStatus(GetMobileStatusReq getMobileStatusReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="setMobileCheckoutReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        SetMobileCheckoutResponseType SetMobileCheckout(SetMobileCheckoutReq setMobileCheckoutReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="setMobileCheckoutReq"></param>
        SetMobileCheckoutResponseType SetMobileCheckout(SetMobileCheckoutReq setMobileCheckoutReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="setMobileCheckoutReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        SetMobileCheckoutResponseType SetMobileCheckout(SetMobileCheckoutReq setMobileCheckoutReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doMobileCheckoutPaymentReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        DoMobileCheckoutPaymentResponseType DoMobileCheckoutPayment(DoMobileCheckoutPaymentReq doMobileCheckoutPaymentReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="doMobileCheckoutPaymentReq"></param>
        DoMobileCheckoutPaymentResponseType DoMobileCheckoutPayment(DoMobileCheckoutPaymentReq doMobileCheckoutPaymentReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doMobileCheckoutPaymentReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        DoMobileCheckoutPaymentResponseType DoMobileCheckoutPayment(DoMobileCheckoutPaymentReq doMobileCheckoutPaymentReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getBalanceReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        GetBalanceResponseType GetBalance(GetBalanceReq getBalanceReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="getBalanceReq"></param>
        GetBalanceResponseType GetBalance(GetBalanceReq getBalanceReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getBalanceReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        GetBalanceResponseType GetBalance(GetBalanceReq getBalanceReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getPalDetailsReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        GetPalDetailsResponseType GetPalDetails(GetPalDetailsReq getPalDetailsReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="getPalDetailsReq"></param>
        GetPalDetailsResponseType GetPalDetails(GetPalDetailsReq getPalDetailsReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getPalDetailsReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        GetPalDetailsResponseType GetPalDetails(GetPalDetailsReq getPalDetailsReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doExpressCheckoutPaymentReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        DoExpressCheckoutPaymentResponseType DoExpressCheckoutPayment(DoExpressCheckoutPaymentReq doExpressCheckoutPaymentReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="doExpressCheckoutPaymentReq"></param>
        DoExpressCheckoutPaymentResponseType DoExpressCheckoutPayment(DoExpressCheckoutPaymentReq doExpressCheckoutPaymentReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doExpressCheckoutPaymentReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        DoExpressCheckoutPaymentResponseType DoExpressCheckoutPayment(DoExpressCheckoutPaymentReq doExpressCheckoutPaymentReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doUATPExpressCheckoutPaymentReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        DoUATPExpressCheckoutPaymentResponseType DoUATPExpressCheckoutPayment(DoUATPExpressCheckoutPaymentReq doUATPExpressCheckoutPaymentReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="doUATPExpressCheckoutPaymentReq"></param>
        DoUATPExpressCheckoutPaymentResponseType DoUATPExpressCheckoutPayment(DoUATPExpressCheckoutPaymentReq doUATPExpressCheckoutPaymentReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doUATPExpressCheckoutPaymentReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        DoUATPExpressCheckoutPaymentResponseType DoUATPExpressCheckoutPayment(DoUATPExpressCheckoutPaymentReq doUATPExpressCheckoutPaymentReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="setAuthFlowParamReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        SetAuthFlowParamResponseType SetAuthFlowParam(SetAuthFlowParamReq setAuthFlowParamReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="setAuthFlowParamReq"></param>
        SetAuthFlowParamResponseType SetAuthFlowParam(SetAuthFlowParamReq setAuthFlowParamReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="setAuthFlowParamReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        SetAuthFlowParamResponseType SetAuthFlowParam(SetAuthFlowParamReq setAuthFlowParamReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getAuthDetailsReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        GetAuthDetailsResponseType GetAuthDetails(GetAuthDetailsReq getAuthDetailsReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="getAuthDetailsReq"></param>
        GetAuthDetailsResponseType GetAuthDetails(GetAuthDetailsReq getAuthDetailsReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getAuthDetailsReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        GetAuthDetailsResponseType GetAuthDetails(GetAuthDetailsReq getAuthDetailsReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="setAccessPermissionsReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        SetAccessPermissionsResponseType SetAccessPermissions(SetAccessPermissionsReq setAccessPermissionsReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="setAccessPermissionsReq"></param>
        SetAccessPermissionsResponseType SetAccessPermissions(SetAccessPermissionsReq setAccessPermissionsReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="setAccessPermissionsReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        SetAccessPermissionsResponseType SetAccessPermissions(SetAccessPermissionsReq setAccessPermissionsReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="updateAccessPermissionsReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        UpdateAccessPermissionsResponseType UpdateAccessPermissions(UpdateAccessPermissionsReq updateAccessPermissionsReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="updateAccessPermissionsReq"></param>
        UpdateAccessPermissionsResponseType UpdateAccessPermissions(UpdateAccessPermissionsReq updateAccessPermissionsReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="updateAccessPermissionsReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        UpdateAccessPermissionsResponseType UpdateAccessPermissions(UpdateAccessPermissionsReq updateAccessPermissionsReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getAccessPermissionDetailsReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        GetAccessPermissionDetailsResponseType GetAccessPermissionDetails(GetAccessPermissionDetailsReq getAccessPermissionDetailsReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="getAccessPermissionDetailsReq"></param>
        GetAccessPermissionDetailsResponseType GetAccessPermissionDetails(GetAccessPermissionDetailsReq getAccessPermissionDetailsReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getAccessPermissionDetailsReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        GetAccessPermissionDetailsResponseType GetAccessPermissionDetails(GetAccessPermissionDetailsReq getAccessPermissionDetailsReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getIncentiveEvaluationReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        GetIncentiveEvaluationResponseType GetIncentiveEvaluation(GetIncentiveEvaluationReq getIncentiveEvaluationReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="getIncentiveEvaluationReq"></param>
        GetIncentiveEvaluationResponseType GetIncentiveEvaluation(GetIncentiveEvaluationReq getIncentiveEvaluationReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getIncentiveEvaluationReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        GetIncentiveEvaluationResponseType GetIncentiveEvaluation(GetIncentiveEvaluationReq getIncentiveEvaluationReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="setExpressCheckoutReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        SetExpressCheckoutResponseType SetExpressCheckout(SetExpressCheckoutReq setExpressCheckoutReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="setExpressCheckoutReq"></param>
        SetExpressCheckoutResponseType SetExpressCheckout(SetExpressCheckoutReq setExpressCheckoutReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="setExpressCheckoutReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        SetExpressCheckoutResponseType SetExpressCheckout(SetExpressCheckoutReq setExpressCheckoutReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="executeCheckoutOperationsReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        ExecuteCheckoutOperationsResponseType ExecuteCheckoutOperations(ExecuteCheckoutOperationsReq executeCheckoutOperationsReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="executeCheckoutOperationsReq"></param>
        ExecuteCheckoutOperationsResponseType ExecuteCheckoutOperations(ExecuteCheckoutOperationsReq executeCheckoutOperationsReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="executeCheckoutOperationsReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        ExecuteCheckoutOperationsResponseType ExecuteCheckoutOperations(ExecuteCheckoutOperationsReq executeCheckoutOperationsReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getExpressCheckoutDetailsReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        GetExpressCheckoutDetailsResponseType GetExpressCheckoutDetails(GetExpressCheckoutDetailsReq getExpressCheckoutDetailsReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="getExpressCheckoutDetailsReq"></param>
        GetExpressCheckoutDetailsResponseType GetExpressCheckoutDetails(GetExpressCheckoutDetailsReq getExpressCheckoutDetailsReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getExpressCheckoutDetailsReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        GetExpressCheckoutDetailsResponseType GetExpressCheckoutDetails(GetExpressCheckoutDetailsReq getExpressCheckoutDetailsReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doDirectPaymentReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        DoDirectPaymentResponseType DoDirectPayment(DoDirectPaymentReq doDirectPaymentReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="doDirectPaymentReq"></param>
        DoDirectPaymentResponseType DoDirectPayment(DoDirectPaymentReq doDirectPaymentReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doDirectPaymentReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        DoDirectPaymentResponseType DoDirectPayment(DoDirectPaymentReq doDirectPaymentReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="managePendingTransactionStatusReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        ManagePendingTransactionStatusResponseType ManagePendingTransactionStatus(ManagePendingTransactionStatusReq managePendingTransactionStatusReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="managePendingTransactionStatusReq"></param>
        ManagePendingTransactionStatusResponseType ManagePendingTransactionStatus(ManagePendingTransactionStatusReq managePendingTransactionStatusReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="managePendingTransactionStatusReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        ManagePendingTransactionStatusResponseType ManagePendingTransactionStatus(ManagePendingTransactionStatusReq managePendingTransactionStatusReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doCancelReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        DoCancelResponseType DoCancel(DoCancelReq doCancelReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="doCancelReq"></param>
        DoCancelResponseType DoCancel(DoCancelReq doCancelReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doCancelReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        DoCancelResponseType DoCancel(DoCancelReq doCancelReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doCaptureReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        DoCaptureResponseType DoCapture(DoCaptureReq doCaptureReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="doCaptureReq"></param>
        DoCaptureResponseType DoCapture(DoCaptureReq doCaptureReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doCaptureReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        DoCaptureResponseType DoCapture(DoCaptureReq doCaptureReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doReauthorizationReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        DoReauthorizationResponseType DoReauthorization(DoReauthorizationReq doReauthorizationReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="doReauthorizationReq"></param>
        DoReauthorizationResponseType DoReauthorization(DoReauthorizationReq doReauthorizationReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doReauthorizationReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        DoReauthorizationResponseType DoReauthorization(DoReauthorizationReq doReauthorizationReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doVoidReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        DoVoidResponseType DoVoid(DoVoidReq doVoidReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="doVoidReq"></param>
        DoVoidResponseType DoVoid(DoVoidReq doVoidReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doVoidReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        DoVoidResponseType DoVoid(DoVoidReq doVoidReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doAuthorizationReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        DoAuthorizationResponseType DoAuthorization(DoAuthorizationReq doAuthorizationReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="doAuthorizationReq"></param>
        DoAuthorizationResponseType DoAuthorization(DoAuthorizationReq doAuthorizationReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doAuthorizationReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        DoAuthorizationResponseType DoAuthorization(DoAuthorizationReq doAuthorizationReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="setCustomerBillingAgreementReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        SetCustomerBillingAgreementResponseType SetCustomerBillingAgreement(SetCustomerBillingAgreementReq setCustomerBillingAgreementReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="setCustomerBillingAgreementReq"></param>
        SetCustomerBillingAgreementResponseType SetCustomerBillingAgreement(SetCustomerBillingAgreementReq setCustomerBillingAgreementReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="setCustomerBillingAgreementReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        SetCustomerBillingAgreementResponseType SetCustomerBillingAgreement(SetCustomerBillingAgreementReq setCustomerBillingAgreementReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getBillingAgreementCustomerDetailsReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        GetBillingAgreementCustomerDetailsResponseType GetBillingAgreementCustomerDetails(GetBillingAgreementCustomerDetailsReq getBillingAgreementCustomerDetailsReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="getBillingAgreementCustomerDetailsReq"></param>
        GetBillingAgreementCustomerDetailsResponseType GetBillingAgreementCustomerDetails(GetBillingAgreementCustomerDetailsReq getBillingAgreementCustomerDetailsReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getBillingAgreementCustomerDetailsReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        GetBillingAgreementCustomerDetailsResponseType GetBillingAgreementCustomerDetails(GetBillingAgreementCustomerDetailsReq getBillingAgreementCustomerDetailsReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="createBillingAgreementReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        CreateBillingAgreementResponseType CreateBillingAgreement(CreateBillingAgreementReq createBillingAgreementReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="createBillingAgreementReq"></param>
        CreateBillingAgreementResponseType CreateBillingAgreement(CreateBillingAgreementReq createBillingAgreementReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="createBillingAgreementReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        CreateBillingAgreementResponseType CreateBillingAgreement(CreateBillingAgreementReq createBillingAgreementReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doReferenceTransactionReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        DoReferenceTransactionResponseType DoReferenceTransaction(DoReferenceTransactionReq doReferenceTransactionReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="doReferenceTransactionReq"></param>
        DoReferenceTransactionResponseType DoReferenceTransaction(DoReferenceTransactionReq doReferenceTransactionReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doReferenceTransactionReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        DoReferenceTransactionResponseType DoReferenceTransaction(DoReferenceTransactionReq doReferenceTransactionReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doNonReferencedCreditReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        DoNonReferencedCreditResponseType DoNonReferencedCredit(DoNonReferencedCreditReq doNonReferencedCreditReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="doNonReferencedCreditReq"></param>
        DoNonReferencedCreditResponseType DoNonReferencedCredit(DoNonReferencedCreditReq doNonReferencedCreditReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doNonReferencedCreditReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        DoNonReferencedCreditResponseType DoNonReferencedCredit(DoNonReferencedCreditReq doNonReferencedCreditReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doUATPAuthorizationReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        DoUATPAuthorizationResponseType DoUATPAuthorization(DoUATPAuthorizationReq doUATPAuthorizationReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="doUATPAuthorizationReq"></param>
        DoUATPAuthorizationResponseType DoUATPAuthorization(DoUATPAuthorizationReq doUATPAuthorizationReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="doUATPAuthorizationReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        DoUATPAuthorizationResponseType DoUATPAuthorization(DoUATPAuthorizationReq doUATPAuthorizationReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="createRecurringPaymentsProfileReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        CreateRecurringPaymentsProfileResponseType CreateRecurringPaymentsProfile(CreateRecurringPaymentsProfileReq createRecurringPaymentsProfileReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="createRecurringPaymentsProfileReq"></param>
        CreateRecurringPaymentsProfileResponseType CreateRecurringPaymentsProfile(CreateRecurringPaymentsProfileReq createRecurringPaymentsProfileReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="createRecurringPaymentsProfileReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        CreateRecurringPaymentsProfileResponseType CreateRecurringPaymentsProfile(CreateRecurringPaymentsProfileReq createRecurringPaymentsProfileReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getRecurringPaymentsProfileDetailsReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        GetRecurringPaymentsProfileDetailsResponseType GetRecurringPaymentsProfileDetails(GetRecurringPaymentsProfileDetailsReq getRecurringPaymentsProfileDetailsReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="getRecurringPaymentsProfileDetailsReq"></param>
        GetRecurringPaymentsProfileDetailsResponseType GetRecurringPaymentsProfileDetails(GetRecurringPaymentsProfileDetailsReq getRecurringPaymentsProfileDetailsReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="getRecurringPaymentsProfileDetailsReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        GetRecurringPaymentsProfileDetailsResponseType GetRecurringPaymentsProfileDetails(GetRecurringPaymentsProfileDetailsReq getRecurringPaymentsProfileDetailsReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="manageRecurringPaymentsProfileStatusReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        ManageRecurringPaymentsProfileStatusResponseType ManageRecurringPaymentsProfileStatus(ManageRecurringPaymentsProfileStatusReq manageRecurringPaymentsProfileStatusReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="manageRecurringPaymentsProfileStatusReq"></param>
        ManageRecurringPaymentsProfileStatusResponseType ManageRecurringPaymentsProfileStatus(ManageRecurringPaymentsProfileStatusReq manageRecurringPaymentsProfileStatusReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="manageRecurringPaymentsProfileStatusReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        ManageRecurringPaymentsProfileStatusResponseType ManageRecurringPaymentsProfileStatus(ManageRecurringPaymentsProfileStatusReq manageRecurringPaymentsProfileStatusReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="billOutstandingAmountReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        BillOutstandingAmountResponseType BillOutstandingAmount(BillOutstandingAmountReq billOutstandingAmountReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="billOutstandingAmountReq"></param>
        BillOutstandingAmountResponseType BillOutstandingAmount(BillOutstandingAmountReq billOutstandingAmountReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="billOutstandingAmountReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        BillOutstandingAmountResponseType BillOutstandingAmount(BillOutstandingAmountReq billOutstandingAmountReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="updateRecurringPaymentsProfileReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        UpdateRecurringPaymentsProfileResponseType UpdateRecurringPaymentsProfile(UpdateRecurringPaymentsProfileReq updateRecurringPaymentsProfileReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="updateRecurringPaymentsProfileReq"></param>
        UpdateRecurringPaymentsProfileResponseType UpdateRecurringPaymentsProfile(UpdateRecurringPaymentsProfileReq updateRecurringPaymentsProfileReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="updateRecurringPaymentsProfileReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        UpdateRecurringPaymentsProfileResponseType UpdateRecurringPaymentsProfile(UpdateRecurringPaymentsProfileReq updateRecurringPaymentsProfileReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="reverseTransactionReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        ReverseTransactionResponseType ReverseTransaction(ReverseTransactionReq reverseTransactionReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="reverseTransactionReq"></param>
        ReverseTransactionResponseType ReverseTransaction(ReverseTransactionReq reverseTransactionReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="reverseTransactionReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        ReverseTransactionResponseType ReverseTransaction(ReverseTransactionReq reverseTransactionReq, ICredential credential);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="externalRememberMeOptOutReq"></param>
        ///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
        ExternalRememberMeOptOutResponseType ExternalRememberMeOptOut(ExternalRememberMeOptOutReq externalRememberMeOptOutReq, string apiUserName);

        /// <summary> 
        /// 
        /// </summary>
        ///<param name="externalRememberMeOptOutReq"></param>
        ExternalRememberMeOptOutResponseType ExternalRememberMeOptOut(ExternalRememberMeOptOutReq externalRememberMeOptOutReq);

        /// <summary>
        /// 
        /// </summary>
        ///<param name="externalRememberMeOptOutReq"></param>
        ///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
        ExternalRememberMeOptOutResponseType ExternalRememberMeOptOut(ExternalRememberMeOptOutReq externalRememberMeOptOutReq, ICredential credential);

        void setAccessToken(string accessToken);
        void setAccessTokenSecret(string accessTokenSecret);
        string getAccessToken();
        string getAccessTokenSecret();
        string getLastRequest();
        string getLastResponse();
    }
}