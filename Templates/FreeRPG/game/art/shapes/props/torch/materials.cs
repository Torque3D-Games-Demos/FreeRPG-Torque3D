//--- torch.DAE MATERIALS BEGIN ---
singleton Material(torch_torch)
{
	mapTo = "torch";

	diffuseMap[0] = "art/shapes/props/torch/tex_torch_dif";
	normalMap[0] = "art/shapes/props/torch/tex_torch_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "65";
   castShadows = "0";
};

//--- torch.DAE MATERIALS END ---

