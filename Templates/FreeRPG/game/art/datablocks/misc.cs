//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

datablock ParticleData(FireTestParticle0)
{
   textureName          = "art/shapes/particles/explosion";
   dragCoeffiecient     = 0;
   gravityCoefficient   = -3.99267;
   inheritedVelFactor   = 0.0;
   constantAcceleration = -8;
   lifetimeMS           = 563;
   lifetimeVarianceMS   = 562;
   useInvAlpha =  false;
   spinRandomMin = -280.0;
   spinRandomMax =  280.0;

   colors[0]     = "1 0.897638 0.795276 0.0944882";
   colors[1]     = "1 0.496063 0 0.299213";
   colors[2]     = "0.0944882 0.0944882 0.0944882 0";

   sizes[0]      = 2.99701;
   sizes[1]      = 3.49753;
   sizes[2]      = 1.03766;

   times[0]      = 0.0;
   times[1]      = 0.121569;
   times[2]      = 1.0;
   dragCoefficient = 1.9697;
   spinSpeed = "0.5";
   animTexName = "art/shapes/particles/explosion";
   sizes[3] = "0";
   times[3] = "1";
};

datablock ParticleEmitterData(FireTestEmitter0)
{
   ejectionPeriodMS = 22;
   ejectionVelocity = 8;
   velocityVariance = 4;
   ejectionOffset = 0;
   thetaMax = "40";
   particles = "FireTestParticle0";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   softnessDistance = 1;
   periodVarianceMS = "10";
};
