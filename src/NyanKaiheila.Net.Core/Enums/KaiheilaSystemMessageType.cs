namespace NyanKaiheila.Net.Core.Enums
{
    /// <summary>
    /// 开合啦系统消息类型
    /// </summary>
    public enum KaiheilaSystemMessageType
    {
        /// <summary>
        /// 更新 / 删除频道消息
        /// </summary>
        updated_message,
        /// <summary>
        /// 用户点击按钮
        /// </summary>
        message_btn_click,
        /// <summary>
        /// 频道消息添加反应
        /// </summary>
        added_reaction,
        /// <summary>
        /// 频道消息删除反应
        /// </summary>
        deleted_reaction,
        /// <summary>
        /// 添加频道
        /// </summary>
        added_channel,
        /// <summary>
        /// 更新频道
        /// </summary>
        updated_channel,
        /// <summary>
        /// 删除频道
        /// </summary>
        deleted_channel,
        /// <summary>
        /// 顶置消息
        /// </summary>
        pinned_message,
        /// <summary>
        /// 取消顶置消息
        /// </summary>
        unpinned_message,
        /// <summary>
        /// 用户加入语音频道
        /// </summary>
        joined_channel,
        /// <summary>
        /// 用户退出语音频道
        /// </summary>
        exited_channel,
        /// <summary>
        /// 自己加入服务器
        /// </summary>
        self_joined_guild,
        /// <summary>
        /// 自己退出服务器
        /// </summary>
        self_exited_guild,
        /// <summary>
        /// 用户信息更新
        /// </summary>
        user_updated,
        /// <summary>
        /// 服务器信息更新
        /// </summary>
        updated_guild,
        /// <summary>
        /// 服务器被删除
        /// </summary>
        deleted_guild,
        /// <summary>
        /// 添加黑名单
        /// </summary>
        added_block_list,
        /// <summary>
        /// 删除黑名单
        /// </summary>
        deleted_block_list,
        /// <summary>
        /// 更新私聊消息
        /// </summary>
        updated_private_message,
        /// <summary>
        /// 删除私聊消息
        /// </summary>
        deleted_private_message,
        /// <summary>
        /// 私聊消息添加反应
        /// </summary>
        private_added_reaction,
        /// <summary>
        /// 私聊消息删除反应
        /// </summary>
        private_deleted_reaction,
        /// <summary>
        /// 自己加入服务器
        /// </summary>
        joined_guild,
        /// <summary>
        /// 自己退出服务器
        /// </summary>
        exited_guild,
        /// <summary>
        /// 服务器成员列表更新
        /// </summary>
        updated_guild_member,
        /// <summary>
        /// 服务器成员上线
        /// </summary>
        guild_member_online,
        /// <summary>
        /// 服务器成员下线
        /// </summary>
        guild_member_offline,
        /// <summary>
        /// 服务器添加角色组
        /// </summary>
        added_role,
        /// <summary>
        /// 服务器更新角色组
        /// </summary>
        updated_role,
        /// <summary>
        /// 服务器删除角色组
        /// </summary>
        deleted_role
    }
}
