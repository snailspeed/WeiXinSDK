﻿namespace Rabbit.WeiXin.Messages.Request
{
    /// <summary>
    /// 视频请求消息。
    /// </summary>
    public class RequestMessageVideo : RequestMessageBase, IMediaMessage
    {
        /// <summary>
        /// 视频消息缩略图的媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        public string ThumbMediaId { get; set; }

        #region Overrides of MessageBase

        /// <summary>
        /// 消息类型。
        /// </summary>
        public override RequestMessageType MessageType
        {
            get { return RequestMessageType.Video; }
        }

        #endregion Overrides of MessageBase

        #region Implementation of IMediaMessage

        /// <summary>
        /// 媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        public string MediaId { get; set; }

        #endregion Implementation of IMediaMessage
    }
}