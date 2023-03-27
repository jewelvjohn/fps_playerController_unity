# FPS Player Controller (unity)
unity player controller for fps gameplay using rigidbody physics.

How to impliment?
1. Create a capsule in the scene hierarchy(player), Now add rigidbody component and the playerController script.

![Alt text](https://raw.githubusercontent.com/jewelvjohn/fps_playerController_unity/main/Guide/Step-1-min.png)

2. Create an empty object at the bottom of the capsule for ground check and assign its transform to the playerController script.
3. Add another empty object object at the face portion of the capsule for using it as a camera holder, assign it's transform to the playerController aswell.

![Alt text](https://raw.githubusercontent.com/jewelvjohn/fps_playerController_unity/main/Guide/Step-2-min.png)

4. Add smoothCamera script as a component to the main camera.

![Alt text](https://raw.githubusercontent.com/jewelvjohn/fps_playerController_unity/main/Guide/Step-3-min.png)

5. Set the terrain's layer to Ground(add new layer) and set playerController 'Ground Mask' as Ground aswell.

![Alt text](https://raw.githubusercontent.com/jewelvjohn/fps_playerController_unity/main/Guide/Step-4-min.png)


![Alt text](https://raw.githubusercontent.com/jewelvjohn/fps_playerController_unity/main/Guide/Step-5-min.png)
