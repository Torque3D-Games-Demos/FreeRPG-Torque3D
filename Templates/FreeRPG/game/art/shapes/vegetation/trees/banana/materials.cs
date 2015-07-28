//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton Material(bananatree_material)
{
   diffuseMap[0] = "art/shapes/vegetation/trees/banana/bananatree_diffuse.dds";
   normalMap[0] = "art/shapes/vegetation/trees/banana/bananatree_normal.dds";
   mapTo = "bananatree";

   pixelSpecular = 0;
   specular = "0.988235 0.988235 0.976471 1";
   specularPower = 1;
      
   translucent = true;
   translucentBlendOp = None;
   translucentZWrite = true;
   alphaTest = true;
   alphaRef = 107;
   
   // NOTE: This would be nice to have!
   backlight = 1;
   backLightFactor = "0.9 1.0 0.2";

   forestWindEnabled = 1;   
   materialTag0 = "Vegetation";
   specularMap[0] = "art/shapes/vegetation/trees/banana/bananatree_specular.dds";

};


//--- bananatree_mature.DAE MATERIALS BEGIN ---

//--- bananatree_mature.DAE MATERIALS END ---

