﻿namespace CardiacComputer.Cli;

public enum Opcodes
{
    /// <summary>
    /// Read a card into memory
    /// </summary>
    INP = 0,
    /// <summary>
    /// Clear accumulator and add from memory (load)
    /// </summary>
    CLA = 1,
    /// <summary>
    /// Add from memory to accumulator
    /// </summary>
    ADD = 2,
    /// <summary>
    /// Test accumulator and jump if negative
    /// </summary>
    TAC = 3,

    /// <summary>
    /// Shift accumulator
    /// </summary>
    SFT = 4,
    /// <summary>
    /// Write memory location to output card
    /// </summary>
    OUT = 5,
    /// <summary>
    /// Store accumulator to memory
    /// </summary>
    STO = 6,
    /// <summary>
    /// Subtract memory from accumulator
    /// </summary>
    SUB = 7,
    /// <summary>
    /// Jump and save PC
    /// </summary>
    JMP = 8,
    /// <summary>
    /// Halt and reset
    /// </summary>
    HRS = 9,

}