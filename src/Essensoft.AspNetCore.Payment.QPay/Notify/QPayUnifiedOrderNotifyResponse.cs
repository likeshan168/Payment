﻿using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.QPay.Notify
{
    public class QPayUnifiedOrderNotifyResponse : QPayNotifyResponse
    {
        /// <summary>
        /// 公众账号ID
        /// </summary>
        [JsonProperty("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 商户号ID
        /// </summary>
        [JsonProperty("mch_id")]
        public string MchId { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        [JsonProperty("nonce_str")]
        public string NonceStr { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        [JsonProperty("device_info")]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 支付场景
        /// </summary>
        [JsonProperty("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 支付状态
        /// </summary>
        [JsonProperty("trade_state")]
        public string TradeState { get; set; }

        /// <summary>
        /// 付款银行
        /// </summary>
        [JsonProperty("bank_type")]
        public string BankType { get; set; }

        /// <summary>
        /// 货币类型
        /// </summary>
        [JsonProperty("fee_type")]
        public string FeeType { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonProperty("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 用户支付金额
        /// </summary>
        [JsonProperty("cash_fee")]
        public string CashFee { get; set; }

        /// <summary>
        /// QQ钱包优惠金额
        /// </summary>
        [JsonProperty("coupon_fee")]
        public string CouponFee { get; set; }

        /// <summary>
        /// QQ钱包订单号
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 附加数据包
        /// </summary>
        [JsonProperty("attach")]
        public string Attach { get; set; }

        /// <summary>
        /// 支付完成时间
        /// </summary>
        [JsonProperty("time_end")]
        public string TimeEnd { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }
    }
}
