﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Device.Spi
{
    /// <summary>
    /// The communications channel to a device on a SPI bus.
    /// </summary>
    public abstract class SpiDevice : IDisposable
    {
        /// <summary>
        /// The connection settings of a device on a SPI bus.
        /// </summary>
        public abstract SpiConnectionSettings ConnectionSettings { get; }

        /// <summary>
        /// Reads a byte from the SPI device.
        /// </summary>
        /// <returns>A byte read from the SPI device.</returns>
        public abstract byte ReadByte();

        /// <summary>
        /// Reads data from the SPI device.
        /// </summary>
        /// <param name="buffer">
        /// The buffer to read the data from the SPI device.
        /// The length of the buffer determines how much data to read from the SPI device.
        /// </param>
        public abstract void Read(Span<byte> buffer);

        /// <summary>
        /// Writes a byte to the SPI device.
        /// </summary>
        /// <param name="data">The byte to be written to the SPI device.</param>
        public abstract void WriteByte(byte data);

        /// <summary>
        /// Writes data to the SPI device.
        /// </summary>
        /// <param name="data">
        /// The buffer that contains the data to be written to the SPI device.
        /// </param>
        public abstract void Write(Span<byte> data);

        /// <summary>
        /// Writes and reads data from the SPI device.
        /// </summary>
        /// <param name="writeBuffer">The buffer that contains the data to be written to the SPI device.</param>
        /// <param name="readBuffer">The buffer to read the data from the SPI device.</param>
        public abstract void TransferFullDuplex(Span<byte> writeBuffer, Span<byte> readBuffer);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            //Nothing to do in base class.
        }
    }
}
