// Copyright 2017 Google Inc. All rights reserved.
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

%module usdRelationship

%{
#include "pxr/usd/usd/relationship.h"
%}

%include "std_vector.i"
namespace std {
	%template(UsdRelationshipVector) vector<UsdRelationship>;
}
typedef std::vector<UsdRelationship> UsdRelationshipVector;

%ignore UsdRelationship::GetForwardedTargets(SdfPathVector* targets) const;
%ignore GetTargets(SdfPathVector* targets) const;


%include "pxr/usd/usd/relationship.h"


%extend UsdRelationship {
  SdfPathVector GetTargets() {
	SdfPathVector targets;
	self->GetTargets(&targets);
	return targets;
  }

   SdfPathVector GetForwardedTargets() const {
   	SdfPathVector targets;
	self->GetForwardedTargets(&targets);
	return targets;
   }
}