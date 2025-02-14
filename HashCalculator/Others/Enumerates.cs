﻿namespace HashCalculator
{
    /// <summary>
    /// 哈希计算任务模型的运行状态
    /// </summary>
    internal enum HashState
    {
        /// <summary>
        /// HashViewModel 初始状态
        /// </summary>
        NoState,

        /// <summary>
        /// HashViewModel 已被加入待计算队列
        /// </summary>
        Waiting,

        /// <summary>
        /// HashViewModel 正在进行哈希值计算
        /// </summary>
        Running,

        /// <summary>
        /// HashViewModel 正进行的哈希计算已暂停
        /// </summary>
        Paused,

        /// <summary>
        /// HashViewModel 已结束哈希值的计算
        /// </summary>
        Finished,
    }

    /// <summary>
    /// 哈希计算任务模型的结果状态
    /// </summary>
    internal enum HashResult
    {
        NoResult,
        Canceled,
        Failed,
        Succeeded,
    }

    /// <summary>
    /// HashViewModel 的 PauseOrContinueModel 方法参数
    /// </summary>
    internal enum PauseMode
    {
        /// <summary>
        /// 暂停任务
        /// </summary>
        Pause,
        /// <summary>
        /// 继续任务
        /// </summary>
        Continue,
        /// <summary>
        /// 反转状态
        /// </summary>
        Invert,
    }

    /// <summary>
    /// 哈希值计算队列任务的完成状态，用于 MainWndViewModel 类
    /// </summary>
    internal enum QueueState
    {
        /// <summary>
        /// 启动前
        /// </summary>
        None,
        /// <summary>
        /// 队列开始
        /// </summary>
        Started,
        /// <summary>
        /// 队列结束
        /// </summary>
        Stopped,
    }

    internal enum CmpRes
    {
        /// <summary>
        /// 没有执行过比较操作
        /// </summary>
        NoResult,

        /// <summary>
        /// 执行过比较操作但没有关联项
        /// </summary>
        Unrelated,

        /// <summary>
        /// 执行过比较操作且已匹配
        /// </summary>
        Matched,

        /// <summary>
        /// 执行过比较操作但不匹配
        /// </summary>
        Mismatch,

        /// <summary>
        /// 执行过比较操作但未能确定是否匹配
        /// </summary>
        Uncertain,
    }

    /// <summary>
    /// 对文件夹的搜索策略
    /// </summary>
    public enum SearchPolicy
    {
        Children,
        Descendants,
        DontSearch,
    }

    /// <summary>
    /// 任务数量限制（同时计算多少个文件的哈希值）
    /// </summary>
    public enum TaskNum
    {
        One = 1,
        Two = 2,
        Four = 4,
        Eight = 8,
    }

    /// <summary>
    /// 哈希算法类型，Unknown 是创建 HashViewModel 实例时的默认值
    /// </summary>
    public enum AlgoType
    {
        SHA1,
        SHA224,
        SHA256,
        SHA384,
        SHA512,
        SHA3_224,
        SHA3_256,
        SHA3_384,
        SHA3_512,
        MD5,
        BLAKE2S,
        BLAKE2B,
        BLAKE3,
        WHIRLPOOL,
        Unknown = -1,
    }

    public enum OutputType
    {
        BASE64,
        BinaryUpper,
        BinaryLower,
        Unknown = -1,
    }

    /// <summary>
    /// 约定的 MemoryMappedFile 内容排布方案版本
    /// 默认约定：MemoryMappedFile 内的前 4 个字节总是代表内容排布方案版本，转为 int 值后强转为此枚举
    /// </summary>
    internal enum MappedVer
    {
        /// <summary>
        /// 未知版本，不读取 MemoryMappedFile 的内容
        /// </summary>
        Unknown,
        /// <summary>
        /// 版本 1，按版本 1 的规则读取 MemoryMappedFile 内容
        ///  0~3 字节：MemoryMappedFile 内容排布方案版本
        ///  4~7 字节：MemoryMappedFile 内容条目数量
        /// 8~11 字节：第一个条目的字节数；12~n 字节：第一个条目的内容，n 是 8~11 字节代表的 int 大小 + 11
        /// </summary>
        Version1,
    }
}
