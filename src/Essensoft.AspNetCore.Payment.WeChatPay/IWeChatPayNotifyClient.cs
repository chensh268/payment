﻿using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public interface IWeChatPayNotifyClient
    {
#if NETCOREAPP3_1
        /// <summary>
        /// 执行 WeChatPay 通知请求解析
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">控制器的请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(Microsoft.AspNetCore.Http.HttpRequest request, WeChatPayOptions options) where T : WeChatPayNotify;
#endif
        /// <summary>
        /// 执行 WeChatPay 通知请求解析
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">控制器的请求</param>
        /// <param name="options">配置选项</param>
        /// <returns>领域对象</returns>
        Task<T> ExecuteAsync<T>(string body, WeChatPayOptions options) where T : WeChatPayNotify;
    }
}
