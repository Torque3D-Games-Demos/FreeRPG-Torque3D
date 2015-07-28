//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
//	Sounds
//-----------------------------------------------------------------------------

singleton SFXDescription( WaterExplosionSFXDesc : AudioEffect )
{
   is3D              = true;
   ReferenceDistance = 10.0;
   MaxDistance       = 40.0;
};

datablock SFXProfile(WaterExplosionSound)
{
filename = "art/sound/underwater_explosion";
description = WaterExplosionSFXDesc;
preload = true;
};

//-----------------------------------------------------------------------------
//	Particles
//-----------------------------------------------------------------------------


datablock ParticleData(WaterMinorBlast1)
{
   textureName          = "art/shapes/particles/FXpack1/waterblast";
   dragCoefficient      = 5;
   gravityCoefficient   = 0.0;
   inheritedVelFactor   = 0.2;
   windCoefficient      = 0;
   constantAcceleration = 0;
   lifetimeMS           = 400;
   lifetimeVarianceMS   = 200;
   spinRandomMin = -20.0;
   spinRandomMax =  20.0;
   useInvAlpha   = true;

   colors[0]     = "1.0 1.0 1.0 0.4";
   colors[1]     = "1.0 1.0 1.0 0.2";
   colors[2]     = "1.0 1.0 1.0 0.0";

   sizes[0]      = 4.0;
   sizes[1]      = 8.0;
   sizes[2]      = 15.0;

   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(WaterMinorBlast1Emitter)
{
   ejectionPeriodMS = 10;
   periodVarianceMS = 5;
   ejectionVelocity = 65.0;
   velocityVariance = 0.5;
   ejectionOffset   = 0.4;
   thetaMin         = 0;
   thetaMax         = 70;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   orientParticles  = true;
   orientOnVelocity = true;
   particles = "WaterMinorBlast1";
};

datablock ParticleData(WaterMinorBlast2)
{
   textureName          = "art/shapes/particles/FXpack1/waterblast";
   dragCoefficient      = 5;
   gravityCoefficient   = 0.0;
   inheritedVelFactor   = 0.2;
   windCoefficient      = 0;
   constantAcceleration = 0;
   lifetimeMS           = 400;
   lifetimeVarianceMS   = 200;
   spinRandomMin = -20.0;
   spinRandomMax =  20.0;
   useInvAlpha   = false;

   colors[0]     = "1.0 1.0 1.0 0.2";
   colors[1]     = "1.0 1.0 1.0 0.1";
   colors[2]     = "1.0 1.0 1.0 0.0";

   sizes[0]      = 4.0;
   sizes[1]      = 8.0;
   sizes[2]      = 15.0;

   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(WaterMinorBlast2Emitter)
{
   ejectionPeriodMS = 10;
   periodVarianceMS = 5;
   ejectionVelocity = 65.0;
   velocityVariance = 0.5;
   ejectionOffset   = 0.4;
   thetaMin         = 0;
   thetaMax         = 10;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   orientParticles  = true;
   orientOnVelocity = true;
   particles = "WaterMinorBlast2";
};

datablock ParticleData(WaterMinorSpray1)
{
   textureName          = "art/shapes/particles/FXpack1/waterspray";
   dragCoeffiecient     = 0.0;
   gravityCoefficient   = 7.0;
   inheritedVelFactor   = 0.0;
   constantAcceleration = 0.0;
   lifetimeMS           = 1200;
   lifetimeVarianceMS   = 800;
   useInvAlpha =  true;
   spinRandomMin = -180.0;
   spinRandomMax =  180.0;

   colors[0]     = "1.0 1.0 1.0 0.5";
   colors[1]     = "1.0 1.0 1.0 0.3";
   colors[2]     = "1.0 1.0 1.0 0.0";

   sizes[0]      = 2.5;
   sizes[1]      = 5.0;
   sizes[2]      = 7.5;

   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(WaterMinorSpray1Emitter)
{
   ejectionPeriodMS = 5;
   periodVarianceMS = 2;
   ejectionVelocity = 40.0;
   velocityVariance = 5.0;
   thetaMin         = 0.0;
   thetaMax         = 15.0;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   particles = "WaterMinorSpray1";
};

datablock ParticleData(WaterMinorSpray2)
{
   textureName          = "art/shapes/particles/FXpack1/waterspray";
   dragCoeffiecient     = 0.0;
   gravityCoefficient   = 7.0;
   inheritedVelFactor   = 0.0;
   constantAcceleration = 0.0;
   lifetimeMS           = 1200;
   lifetimeVarianceMS   = 800;
   useInvAlpha =  true;
   spinRandomMin = -180.0;
   spinRandomMax =  180.0;

   colors[0]     = "1.0 1.0 1.0 0.5";
   colors[1]     = "1.0 1.0 1.0 0.3";
   colors[2]     = "1.0 1.0 1.0 0.0";

   sizes[0]      = 2.0;
   sizes[1]      = 6.0;
   sizes[2]      = 10.0;

   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(WaterMinorSpray2Emitter)
{
   ejectionPeriodMS = 5;
   periodVarianceMS = 2;
   ejectionVelocity = 35.0;
   velocityVariance = 5.0;
   thetaMin         = 10.0;
   thetaMax         = 40.0;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   particles = "WaterMinorSpray2";
};


datablock ParticleData(WaterMinorVolume)
{
   textureName          = "art/shapes/particles/FXpack1/watervapor";
   dragCoeffiecient     = 0.0;
   gravityCoefficient   = 2.0;
   inheritedVelFactor   = 0.0;
   constantAcceleration = 0.0;
   lifetimeMS           = 1000;
   lifetimeVarianceMS   = 200;
   useInvAlpha =  true;
   spinRandomMin = -80.0;
   spinRandomMax =  80.0;

   colors[0]     = "1.0 1.0 1.0 0.75";
   colors[1]     = "1.0 1.0 1.0 0.4";
   colors[2]     = "1.0 1.0 1.0 0.0";

   sizes[0]      = 2.0;
   sizes[1]      = 6.0;
   sizes[2]      = 10.0;

   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(WaterMinorVolumeEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;
   ejectionVelocity = 7.0;
   velocityVariance = 2.0;
   thetaMin         = 0.0;
   thetaMax         = 50.0;
   particles = "WaterMinorVolume";
   ambientFactor = "0.416667";
   blendStyle = "NORMAL";
};



//-----------------------------------------------------------------------------
//	Explosions
//-----------------------------------------------------------------------------


datablock ExplosionData(WaterMinorExplosion)
{
   soundProfile = WaterExplosionSound;
   lifeTimeMS = 100;

   // Volume
   particleEmitter = WaterMinorVolumeEmitter;
   particleDensity = 10;
   particleRadius = 1.5;

   // Point emission
   emitter[0] = WaterMinorBlast1Emitter;
   emitter[1] = WaterMinorBlast2Emitter;
   emitter[2] = WaterMinorSpray1Emitter;
   emitter[3] = WaterMinorSpray2Emitter;
   
   
    // Camera Shaking
    shakeCamera = true;
    camShakeFreq = "10.0 11.0 9.0";
    camShakeAmp = "8.0 8.0 8.0";
    camShakeDuration = 1.5;
    camShakeRadius = 10;   
};

