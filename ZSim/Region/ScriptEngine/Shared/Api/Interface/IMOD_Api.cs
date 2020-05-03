/*
 * Copyright (c) Contributors, http://opensimulator.org/
 * See CONTRIBUTORS.TXT for a full list of copyright holders.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of the OpenSimulator Project nor the
 *       names of its contributors may be used to endorse or promote products
 *       derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE DEVELOPERS ``AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE CONTRIBUTORS BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System.Collections;
using ZSim.Region.ScriptEngine.Interfaces;

using LSL_Float = ZSim.Region.ScriptEngine.Shared.LSL_Types.LSLFloat;
using LSL_Integer = ZSim.Region.ScriptEngine.Shared.LSL_Types.LSLInteger;
using LSL_Key = ZSim.Region.ScriptEngine.Shared.LSL_Types.LSLString;
using LSL_List = ZSim.Region.ScriptEngine.Shared.LSL_Types.list;
using LSL_Rotation = ZSim.Region.ScriptEngine.Shared.LSL_Types.Quaternion;
using LSL_String = ZSim.Region.ScriptEngine.Shared.LSL_Types.LSLString;
using LSL_Vector = ZSim.Region.ScriptEngine.Shared.LSL_Types.Vector3;

namespace ZSim.Region.ScriptEngine.Shared.Api.Interfaces
{
    public interface IMOD_Api
    {
        // Invocation functions
        void modInvokeN(string fname, params object[] parms);
        LSL_String modInvokeS(string fname, params object[] parms);
        LSL_Integer modInvokeI(string fname, params object[] parms);
        LSL_Float modInvokeF(string fname, params object[] parms);
        LSL_Key modInvokeK(string fname, params object[] parms);
        LSL_Vector modInvokeV(string fname, params object[] parms);
        LSL_Rotation modInvokeR(string fname, params object[] parms);
        LSL_List modInvokeL(string fname, params object[] parms);

        //Module functions
        string modSendCommand(string modules, string command, string k);
    }
}
