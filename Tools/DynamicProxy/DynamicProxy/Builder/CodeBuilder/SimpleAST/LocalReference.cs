// Copyright 2004 DigitalCraftsmen - http://www.digitalcraftsmen.com.br/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.DynamicProxy.Builder.CodeBuilder.SimpleAST
{
	using System;
	using System.Reflection.Emit;

	/// <summary>
	/// Summary description for LocalReference.
	/// </summary>
	public class LocalReference : TypeReference
	{
		private LocalBuilder _localbuilder;

		public LocalReference( Type type ) : base( type )
		{
		}

		public override void Generate(ILGenerator gen)
		{
			_localbuilder = gen.DeclareLocal( base.Type );
		}

		public override void LoadReference(ILGenerator gen)
		{
			gen.Emit( OpCodes.Ldloc, _localbuilder );
		}

		public override void StoreReference(ILGenerator gen)
		{
			gen.Emit( OpCodes.Stloc, _localbuilder );
		}
	}
}
