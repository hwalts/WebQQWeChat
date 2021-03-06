﻿using System.ComponentModel;

namespace HttpAction.Event
{
    [Description("动作事件类型")]
    public enum ActionEventType
    {
        [Description("成功")]
        EvtOK,
        [Description("错误")]
        EvtError,
        [Description("取消")]
        EvtCanceled,
        [Description("重试")]
        EvtRetry,
        [Description("再次执行")]
        EvtRepeat
    }
}
