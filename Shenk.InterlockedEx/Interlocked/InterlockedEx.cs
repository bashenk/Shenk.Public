using System.Runtime.CompilerServices;

namespace Shenk.Interlocked {
//    [TypeForwardedFrom("System.Threading, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public static class InterlockedEx {

        /// <summary>
        /// <see cref="short"/> equivalent of <see cref="System.Threading.Interlocked.Add(ref int, int)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Add(ref int, int)"/>
        public static short Add(ref short location1, short value) {
            int signed = System.Threading.Interlocked.Add(ref Unsafe.As<short, int>(ref location1), Unsafe.As<short, int>(ref value));
            return Unsafe.As<int, short>(ref signed);
        }

        /// <summary>
        /// <see cref="ushort"/> equivalent of <see cref="System.Threading.Interlocked.Add(ref int, int)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Add(ref int, int)"/>
        public static ushort Add(ref ushort location1, ushort value) {
            int signed = System.Threading.Interlocked.Add(ref Unsafe.As<ushort, int>(ref location1), Unsafe.As<ushort, int>(ref value));
            return Unsafe.As<int, ushort>(ref signed);
        }

        /// <summary>
        /// unsigned equivalent of <see cref="System.Threading.Interlocked.Add(ref int, int)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Add(ref int, int)"/>
        public static uint Add(ref uint location1, uint value) {
            int signed = System.Threading.Interlocked.Add(ref Unsafe.As<uint, int>(ref location1), Unsafe.As<uint, int>(ref value));
            return Unsafe.As<int, uint>(ref signed);
        }

        /// <summary>
        /// unsigned equivalent of <see cref="System.Threading.Interlocked.Add(ref long, long)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Add(ref long, long)"/>
        public static ulong Add(ref ulong location1, ulong value) {
            long signed = System.Threading.Interlocked.Add(ref Unsafe.As<ulong, long>(ref location1),
                Unsafe.As<ulong, long>(ref value));
            return Unsafe.As<long, ulong>(ref signed);
        }

        /// <summary>
        /// <see cref="short"/> equivalent of <see cref="System.Threading.Interlocked.CompareExchange(ref int, int, int)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.CompareExchange(ref int, int, int)"/>
        public static short CompareExchange(ref short location1, short value, short comparand) {
            int signed = System.Threading.Interlocked.CompareExchange(ref Unsafe.As<short, int>(ref location1),
                Unsafe.As<short, int>(ref value), Unsafe.As<short, int>(ref comparand));
            return Unsafe.As<int, short>(ref signed);
        }

        /// <summary>
        /// <see cref="ushort"/> equivalent of <see cref="System.Threading.Interlocked.CompareExchange(ref int, int, int)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.CompareExchange(ref int, int, int)"/>
        public static ushort CompareExchange(ref ushort location1, ushort value, ushort comparand) {
            int signed = System.Threading.Interlocked.CompareExchange(ref Unsafe.As<ushort, int>(ref location1),
                Unsafe.As<ushort, int>(ref value), Unsafe.As<ushort, int>(ref comparand));
            return Unsafe.As<int, ushort>(ref signed);
        }

        /// <summary>
        /// unsigned equivalent of <see cref="System.Threading.Interlocked.CompareExchange(ref int, int, int)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.CompareExchange(ref int, int, int)"/>
        public static uint CompareExchange(ref uint location1, uint value, uint comparand) {
            int signed = System.Threading.Interlocked.CompareExchange(ref Unsafe.As<uint, int>(ref location1),
                Unsafe.As<uint, int>(ref value), Unsafe.As<uint, int>(ref comparand));
            return Unsafe.As<int, uint>(ref signed);
        }

        /// <summary>
        /// unsigned equivalent of <see cref="System.Threading.Interlocked.CompareExchange(ref long, long, long)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.CompareExchange(ref long, long, long)"/>
        public static ulong CompareExchange(ref ulong location1, ulong value, ulong comparand) {
            long signed = System.Threading.Interlocked.CompareExchange(ref Unsafe.As<ulong, long>(ref location1),
                Unsafe.As<ulong, long>(ref value), Unsafe.As<ulong, long>(ref comparand));
            return Unsafe.As<long, ulong>(ref signed);
        }

        /// <summary>
        /// <see cref="short"/> equivalent of <see cref="System.Threading.Interlocked.Decrement(ref int)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Decrement(ref int)"/>
        public static short Decrement(ref short location) {
            int signed = System.Threading.Interlocked.Decrement(ref Unsafe.As<short, int>(ref location));
            return Unsafe.As<int, short>(ref signed);
        }

        /// <summary>
        /// <see cref="ushort"/> equivalent of <see cref="System.Threading.Interlocked.Decrement(ref int)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Decrement(ref int)"/>
        public static ushort Decrement(ref ushort location) {
            int signed = System.Threading.Interlocked.Decrement(ref Unsafe.As<ushort, int>(ref location));
            return Unsafe.As<int, ushort>(ref signed);
        }

        /// <summary>
        /// unsigned equivalent of <see cref="System.Threading.Interlocked.Decrement(ref int)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Decrement(ref int)"/>
        public static uint Decrement(ref uint location) {
            int signed = System.Threading.Interlocked.Decrement(ref Unsafe.As<uint, int>(ref location));
            return Unsafe.As<int, uint>(ref signed);
        }

        /// <summary>
        /// unsigned equivalent of <see cref="System.Threading.Interlocked.Decrement(ref long)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Decrement(ref long)"/>
        public static ulong Decrement(ref ulong location) {
            long signed = System.Threading.Interlocked.Decrement(ref Unsafe.As<ulong, long>(ref location));
            return Unsafe.As<long, ulong>(ref signed);
        }

        /// <summary>
        /// unsigned equivalent of <see cref="System.Threading.Interlocked.Exchange(ref int,int)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Exchange(ref int,int)"/>
        public static short Exchange(ref short location1, short value) {
            int signed = System.Threading.Interlocked.Exchange(ref Unsafe.As<short, int>(ref location1),Unsafe.As<short, int>(ref value));
            return Unsafe.As<int, short>(ref signed);
        }

        /// <summary>
        /// unsigned equivalent of <see cref="System.Threading.Interlocked.Exchange(ref int,int)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Exchange(ref int,int)"/>
        public static ushort Exchange(ref ushort location1, ushort value) {
            int signed = System.Threading.Interlocked.Exchange(ref Unsafe.As<ushort, int>(ref location1),Unsafe.As<ushort, int>(ref value));
            return Unsafe.As<int, ushort>(ref signed);
        }

        /// <summary>
        /// unsigned equivalent of <see cref="System.Threading.Interlocked.Exchange(ref int,int)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Exchange(ref int,int)"/>
        public static uint Exchange(ref uint location1, uint value) {
            int signed = System.Threading.Interlocked.Exchange(ref Unsafe.As<uint, int>(ref location1),Unsafe.As<uint, int>(ref value));
            return Unsafe.As<int, uint>(ref signed);
        }

        /// <summary>
        /// unsigned equivalent of <see cref="System.Threading.Interlocked.Exchange(ref long,long)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Exchange(ref long,long)"/>
        public static ulong Exchange(ref ulong location1, ulong value) {
            long signed = System.Threading.Interlocked.Exchange(ref Unsafe.As<ulong, long>(ref location1),Unsafe.As<ulong, long>(ref value));
            return Unsafe.As<long, ulong>(ref signed);
        }

        /// <summary>
        /// <see cref="short"/> equivalent of <see cref="System.Threading.Interlocked.Increment(ref int)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Increment(ref int)"/>
        public static short Increment(ref short location) {
            int signed = System.Threading.Interlocked.Increment(ref Unsafe.As<short, int>(ref location));
            return Unsafe.As<int, short>(ref signed);
        }

        /// <summary>
        /// <see cref="ushort"/> equivalent of <see cref="System.Threading.Interlocked.Increment(ref int)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Increment(ref int)"/>
        public static ushort Increment(ref ushort location) {
            int signed = System.Threading.Interlocked.Increment(ref Unsafe.As<ushort, int>(ref location));
            return Unsafe.As<int, ushort>(ref signed);
        }

        /// <summary>
        /// unsigned equivalent of <see cref="System.Threading.Interlocked.Increment(ref int)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Increment(ref int)"/>
        public static uint Increment(ref uint location) {
            int signed = System.Threading.Interlocked.Increment(ref Unsafe.As<uint, int>(ref location));
            return Unsafe.As<int, uint>(ref signed);
        }

        /// <summary>
        /// unsigned equivalent of <see cref="System.Threading.Interlocked.Increment(ref long)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Increment(ref long)"/>
        public static ulong Increment(ref ulong location) {
            long signed = System.Threading.Interlocked.Increment(ref Unsafe.As<ulong, long>(ref location));
            return Unsafe.As<long, ulong>(ref signed);
        }

        /// <summary>
        /// <see cref="short"/> equivalent of <see cref="System.Threading.Interlocked.Read(ref long)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Read(ref long)"/>
        public static short Read(ref short location) {
            long signed = System.Threading.Interlocked.Read(ref Unsafe.As<short, long>(ref location));
            return Unsafe.As<long, short>(ref signed);
        }

        /// <summary>
        /// <see cref="ushort"/> equivalent of <see cref="System.Threading.Interlocked.Read(ref long)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Read(ref long)"/>
        public static ushort Read(ref ushort location) {
            long signed = System.Threading.Interlocked.Read(ref Unsafe.As<ushort, long>(ref location));
            return Unsafe.As<long, ushort>(ref signed);
        }

        /// <summary>
        /// <see cref="int"/> equivalent of <see cref="System.Threading.Interlocked.Read(ref long)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Read(ref long)"/>
        public static int Read(ref int location) {
            long signed = System.Threading.Interlocked.Read(ref Unsafe.As<int, long>(ref location));
            return Unsafe.As<long, int>(ref signed);
        }

        /// <summary>
        /// <see cref="uint"/> equivalent of <see cref="System.Threading.Interlocked.Read(ref long)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Read(ref long)"/>
        public static uint Read(ref uint location) {
            long signed = System.Threading.Interlocked.Read(ref Unsafe.As<uint, long>(ref location));
            return Unsafe.As<long, uint>(ref signed);
        }

        /// <summary>
        /// unsigned equivalent of <see cref="System.Threading.Interlocked.Read(ref long)"/>
        /// </summary>
        /// <inheritdoc cref="System.Threading.Interlocked.Read(ref long)"/>
        public static ulong Read(ref ulong location) {
            long signed = System.Threading.Interlocked.Read(ref Unsafe.As<ulong, long>(ref location));
            return Unsafe.As<long, ulong>(ref signed);
        }

    }
}
