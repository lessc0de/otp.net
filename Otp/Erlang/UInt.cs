/*``The contents of this file are subject to the Erlang Public License,
* Version 1.1, (the "License"); you may not use this file except in
* compliance with the License. You should have received a copy of the
* Erlang Public License along with this software. If not, it can be
* retrieved via the world wide web at http://www.erlang.org/.
* 
* Software distributed under the License is distributed on an "AS IS"
* basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See
* the License for the specific language governing rights and limitations
* under the License.
* 
* The Initial Developer of the Original Code is Ericsson Utvecklings AB.
* Portions created by Ericsson are Copyright 1999, Ericsson Utvecklings
* AB. All Rights Reserved.''
* 
 * Converted from Java to C# by Vlad Dumitrescu (vlad_Dumitrescu@hotmail.com)
*/
namespace Otp.Erlang
{
	using System;
	
	/*
	* Provides a C# representation of Erlang integral types. 
	**/
	[Serializable]
    public class UInt:Erlang.Long
	{
		/*
		* Create an Erlang integer from the given value.
		*
		* @param i the non-negative int value to use.
		*
		* @exception RangeException if the value is negative.
		**/
		public UInt(int i):base(i)
		{
			
			int j = uIntValue();
		}
		
		/*
		* Create an Erlang integer from a stream containing an integer encoded
		* in Erlang external format.
		*
		* @param buf the stream containing the encoded value.
		* 
		* @exception DecodeException if the buffer does not
		* contain a valid external representation of an Erlang integer.
		*
		* @exception RangeException if the value is too large to
		* be represented as an int, or the value is negative.
		**/
		public UInt(OtpInputStream buf):base(buf)
		{
			
			int j = uIntValue();
		}

        public override Type Type { get { return GetType(); } }

        public override TermType TermType { get { return TermType.Int; } }
	}
}