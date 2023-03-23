# FPS Player Controller (unity)
unity player controller for fps gameplay using rigidbody physics.

How to impliment?
1. Create a capsule in the scene hierarchy(player), Now add rigidbody component and the playerController script.
2. Create an empty object at the bottom of the capsule for ground check and assign its transform to the playerController script.
3. Add another empty object object at the face portion of the capsule for using it as a camera holder, assign it's transform to the playerController aswell.
4. Add smoothCamera script as a component to the main camera.
5. Set the terrain's layer to Ground(add new layer) and set playerController 'Ground Mask' as Ground aswell.
