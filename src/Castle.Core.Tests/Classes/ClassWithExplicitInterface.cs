// Copyright 2004-2010 Castle Project - http://www.castleproject.org/
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

namespace Castle.DynamicProxy.Tests.Classes
{
	using System;

#if !SILVERLIGHT
	[Serializable]
#endif
	public class ClassWithExplicitInterface : ISimpleInterface
	{
		int ISimpleInterface.Do()
		{
			return 5;
		}

		public virtual int DoVirtual()
		{
			return 7;
		}
	}

#if !SILVERLIGHT
	[Serializable]
#endif
	public class ClassWithInterface : ISimpleInterface
	{
		public int Do()
		{
			return 5;
		}
	}

	public class ClassWithVirtualInterface : ISimpleInterface
	{
		public virtual int Do()
		{
			return 5;
		}
	}
}