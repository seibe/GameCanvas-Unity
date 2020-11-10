/*------------------------------------------------------------*/
਍⼀⼀ 㰀猀甀洀洀愀爀礀㸀䜀愀洀攀䌀愀渀瘀愀猀 昀漀爀 唀渀椀琀礀㰀⼀猀甀洀洀愀爀礀㸀ഀഀ
// <author>Seibe TAKAHASHI</author>
਍⼀⼀ 㰀爀攀洀愀爀欀猀㸀ഀഀ
// (c) 2015-2020 Smart Device Programming.
਍⼀⼀ 吀栀椀猀 猀漀昀琀眀愀爀攀 椀猀 爀攀氀攀愀猀攀搀 甀渀搀攀爀 琀栀攀 䴀䤀吀 䰀椀挀攀渀猀攀⸀ഀഀ
// http://opensource.org/licenses/mit-license.php
਍⼀⼀ 㰀⼀爀攀洀愀爀欀猀㸀ഀഀ
/*------------------------------------------------------------*/
਍甀猀椀渀最 匀礀猀琀攀洀⸀䌀漀洀瀀漀渀攀渀琀䴀漀搀攀氀㬀ഀഀ
using Unity.Collections;
਍ഀഀ
namespace GameCanvas
਍笀ഀഀ
    public interface IInputAcceleration
਍    笀ഀഀ
        /// <summary>
਍        ⼀⼀⼀ 䴀�湖픰ﰰّ䵎殖ᰰ響坑弰‰ꀀὒꚐꑞ�젰渰瀰൥ഀ
        /// </summary>
਍        椀渀琀 䄀挀挀攀氀攀爀愀琀椀漀渀䔀瘀攀渀琀䌀漀甀渀琀 笀 最攀琀㬀 紀ഀഀ

਍        ⼀⼀⼀ 㰀猀甀洀洀愀爀礀㸀ഀഀ
        /// 前回のフレーム処理以降に検出した 加速度イベントの列挙子
਍        ⼀⼀⼀ 㰀⼀猀甀洀洀愀爀礀㸀ഀഀ
        GcAccelerationEvent.Enumerable AccelerationEvents { get; }
਍ഀഀ
        /// <summary>
਍        ⼀⼀⼀ 䴀�湖픰ﰰّ䵎殖‰ꀀὒꚐꑞ�젰渰끦䱥䈰挰弰䬰椰䘰䬰രഀ
        /// </summary>
਍        戀漀漀氀 䐀椀搀唀瀀搀愀琀攀䄀挀挀攀氀攀爀愀琀椀漀渀吀栀椀猀䘀爀愀洀攀 笀 最攀琀㬀 紀ഀഀ

਍        ⼀⼀⼀ 㰀猀甀洀洀愀爀礀㸀ഀഀ
        /// 加速度計が有効かどうか
਍        ⼀⼀⼀ 㰀⼀猀甀洀洀愀爀礀㸀ഀഀ
        bool IsAccelerometerEnabled { get; set; }
਍ഀഀ
        /// <summary>
਍        ⼀⼀⼀  豧歟ᰰ響坑弰ꀰὒꚐꑞ�젰രഀ
        /// </summary>
਍        䜀挀䄀挀挀攀氀攀爀愀琀椀漀渀䔀瘀攀渀琀 䰀愀猀琀䄀挀挀攀氀攀爀愀琀椀漀渀䔀瘀攀渀琀 笀 最攀琀㬀 紀ഀഀ

਍        ⼀⼀⼀ 㰀猀甀洀洀愀爀礀㸀ഀഀ
        /// 前回のフレーム処理以降に検出した 加速度イベントの取得を試みます
਍        ⼀⼀⼀ 㰀⼀猀甀洀洀愀爀礀㸀ഀഀ
        /// <param name="i">イベントインデックス（0 から <see cref="AccelerationEventCount"/>-1 までの連番）</param>
਍        ⼀⼀⼀ 㰀瀀愀爀愀洀 渀愀洀攀㴀∀攀∀㸀ꐀ�젰㰰⼀瀀愀爀愀洀㸀ഀഀ
        /// <returns>ポインターイベントを取得できたかどうか</returns>
਍        戀漀漀氀 吀爀礀䜀攀琀䄀挀挀攀氀攀爀愀琀椀漀渀䔀瘀攀渀琀⠀椀渀琀 椀Ⰰ 漀甀琀 䜀挀䄀挀挀攀氀攀爀愀琀椀漀渀䔀瘀攀渀琀 攀⤀㬀ഀഀ

਍        ⼀⼀⼀ 㰀猀甀洀洀愀爀礀㸀ഀഀ
        /// 前回のフレーム処理以降に検出した 加速度イベントの取得を試みます
਍        ⼀⼀⼀ 㰀⼀猀甀洀洀愀爀礀㸀ഀഀ
        /// <param name="array">イベント配列</param>
਍        ⼀⼀⼀ 㰀瀀愀爀愀洀 渀愀洀攀㴀∀挀漀甀渀琀∀㸀ꐀ�젰䴰ទ湒脰₉災㱥⼀瀀愀爀愀洀㸀ഀഀ
        /// <returns>1つ以਍湎ꀰὒꚐꑞ�젰䰰䈰挰弰䬰椰䘰䬰㰰⼀爀攀琀甀爀渀猀㸀ഀഀ
        bool TryGetAccelerationEvents(out NativeArray<GcAccelerationEvent>.ReadOnly array, out int count);
਍    紀ഀഀ

਍    瀀甀戀氀椀挀 椀渀琀攀爀昀愀挀攀 䤀䤀渀瀀甀琀䄀挀挀攀氀攀爀愀琀椀漀渀䔀砀 㨀 䤀䤀渀瀀甀琀䄀挀挀攀氀攀爀愀琀椀漀渀ഀഀ
    {
਍        ⼀⼀⼀ 㰀猀甀洀洀愀爀礀㸀ഀഀ
        /// 最後に検出した加速度イベントの X方向の加速度
਍        ⼀⼀⼀ 㰀⼀猀甀洀洀愀爀礀㸀ഀഀ
        [System.Obsolete("Use to `LastAcceleration`  instead.")]
਍        嬀䔀搀椀琀漀爀䈀爀漀眀猀愀戀氀攀⠀䔀搀椀琀漀爀䈀爀漀眀猀愀戀氀攀匀琀愀琀攀⸀一攀瘀攀爀⤀崀ഀഀ
        float AccelerationLastX { get; }
਍ഀഀ
        /// <summary>
਍        ⼀⼀⼀  豧歟ᰰ響坑弰ꀰὒꚐꑞ�젰渰‰夀뤀ᅥ湔ꀰὒꚐ൞ഀ
        /// </summary>
਍        嬀匀礀猀琀攀洀⸀伀戀猀漀氀攀琀攀⠀∀唀猀攀 琀漀 怀䰀愀猀琀䄀挀挀攀氀攀爀愀琀椀漀渀怀 椀渀猀琀攀愀搀⸀∀⤀崀ഀഀ
        [EditorBrowsable(EditorBrowsableState.Never)]
਍        昀氀漀愀琀 䄀挀挀攀氀攀爀愀琀椀漀渀䰀愀猀琀夀 笀 最攀琀㬀 紀ഀഀ

਍        ⼀⼀⼀ 㰀猀甀洀洀愀爀礀㸀ഀഀ
        /// 最後に検出した加速度イベントの Z方向の加速度
਍        ⼀⼀⼀ 㰀⼀猀甀洀洀愀爀礀㸀ഀഀ
        [System.Obsolete("Use to `LastAcceleration`  instead.")]
਍        嬀䔀搀椀琀漀爀䈀爀漀眀猀愀戀氀攀⠀䔀搀椀琀漀爀䈀爀漀眀猀愀戀氀攀匀琀愀琀攀⸀一攀瘀攀爀⤀崀ഀഀ
        float AccelerationLastZ { get; }
਍ഀഀ
        [System.Obsolete("Use to `TryGetAccelerationEvent`  instead.")]
਍        嬀䔀搀椀琀漀爀䈀爀漀眀猀愀戀氀攀⠀䔀搀椀琀漀爀䈀爀漀眀猀愀戀氀攀匀琀愀琀攀⸀一攀瘀攀爀⤀崀ഀഀ
        float GetAccelerationX(in int i, in bool normalize = false);
਍ഀഀ
        [System.Obsolete("Use to `TryGetAccelerationEvent`  instead.")]
਍        嬀䔀搀椀琀漀爀䈀爀漀眀猀愀戀氀攀⠀䔀搀椀琀漀爀䈀爀漀眀猀愀戀氀攀匀琀愀琀攀⸀一攀瘀攀爀⤀崀ഀഀ
        float GetAccelerationY(in int i, in bool normalize = false);
਍ഀഀ
        [System.Obsolete("Use to `TryGetAccelerationEvent`  instead.")]
਍        嬀䔀搀椀琀漀爀䈀爀漀眀猀愀戀氀攀⠀䔀搀椀琀漀爀䈀爀漀眀猀愀戀氀攀匀琀愀琀攀⸀一攀瘀攀爀⤀崀ഀഀ
        float GetAccelerationZ(in int i, in bool normalize = false);
਍    紀ഀഀ
}
਍
