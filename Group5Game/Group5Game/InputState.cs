#region File Description
//-----------------------------------------------------------------------------
// InputState.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Bot
{
    /// <summary>
    /// Helper for reading input from keyboard, gamepad, and touch input. This class tracks both the current and previous state of the input 
    /// devices, and implements query methods for high level input actions such as "move up through the menu" or "pause the game".
    /// </summary>
    public class InputState
    {

        public const int MaxInputs = 4;

        public KeyboardState CurrentKeyboardState;
        public KeyboardState LastKeyboardState;

        public MouseState CurrentMouseState;
        public MouseState LastMouseState;

        public readonly GamePadState[] CurrentGamePadStates;
        public readonly GamePadState[] LastGamePadStates;

        public readonly bool[] GamePadWasConnected;

        /// <summary>Constructs a new input state.</summary>
        public InputState()
        {
            CurrentKeyboardState = new KeyboardState();
            LastKeyboardState = new KeyboardState();

            CurrentMouseState = new MouseState();
            LastMouseState = new MouseState();

            CurrentGamePadStates = new GamePadState[MaxInputs];
            LastGamePadStates = new GamePadState[MaxInputs];

            GamePadWasConnected = new bool[MaxInputs];
        }

        /// <summary>Reads the latest state of the keyboard and gamepad.</summary>
        public void Update()
        {
            LastKeyboardState = CurrentKeyboardState;
            CurrentKeyboardState = Keyboard.GetState();

            LastMouseState = CurrentMouseState;
            CurrentMouseState = Mouse.GetState();

            for (int i = 0; i < MaxInputs; i++)
            {
                LastGamePadStates[i] = CurrentGamePadStates[i];
                CurrentGamePadStates[i] = GamePad.GetState((PlayerIndex)i);
                if (CurrentGamePadStates[i].IsConnected) GamePadWasConnected[i] = true;
            }
        }

        /// <summary>
        /// The controllingPlayer parameter specifies which player to read input for.
        /// If this is null, it will accept input from any player. When a keypress is detected, the output playerIndex reports which 
        /// player pressed it.
        /// </summary>
        public bool IsNewKeyPress(Keys key, PlayerIndex? controllingPlayer, out PlayerIndex playerIndex)
        {
            if (controllingPlayer.HasValue)
            {
                playerIndex = controllingPlayer.Value;
                int i = (int)playerIndex;
                return (CurrentKeyboardState.IsKeyDown(key) && LastKeyboardState.IsKeyUp(key));
            }
            else
            {
                return (IsNewKeyPress(key, PlayerIndex.One, out playerIndex) || IsNewKeyPress(key, PlayerIndex.Two, out playerIndex) ||
                        IsNewKeyPress(key, PlayerIndex.Three, out playerIndex) || IsNewKeyPress(key, PlayerIndex.Four, out playerIndex));
            }
        }

        public bool IsNewKeyUnpress(Keys key, PlayerIndex? controllingPlayer, out PlayerIndex playerIndex)
        {
            if (controllingPlayer.HasValue)
            {
                playerIndex = controllingPlayer.Value;
                int i = (int)playerIndex;
                return (CurrentKeyboardState.IsKeyUp(key) && LastKeyboardState.IsKeyDown(key));
            }
            else
            {
                return (IsNewKeyUnpress(key, PlayerIndex.One, out playerIndex) || IsNewKeyUnpress(key, PlayerIndex.Two, out playerIndex) ||
                        IsNewKeyUnpress(key, PlayerIndex.Three, out playerIndex) || IsNewKeyUnpress(key, PlayerIndex.Four, out playerIndex));
            }
        }


        /// <summary>
        /// The controllingPlayer parameter specifies which player to read input for.
        /// If this is null, it will accept input from any player. When a button press
        /// is detected, the output playerIndex reports which player pressed it.
        /// </summary>
        public bool IsNewBtnPress(Buttons button, PlayerIndex? controllingPlayer, out PlayerIndex playerIndex)
        {
            if (controllingPlayer.HasValue)
            {
                playerIndex = controllingPlayer.Value;
                int i = (int)playerIndex;
                return (CurrentGamePadStates[i].IsButtonDown(button) && LastGamePadStates[i].IsButtonUp(button));
            }
            else
            {
                return (IsNewBtnPress(button, PlayerIndex.One, out playerIndex) || IsNewBtnPress(button, PlayerIndex.Two, out playerIndex) ||
                        IsNewBtnPress(button, PlayerIndex.Three, out playerIndex) || IsNewBtnPress(button, PlayerIndex.Four, out playerIndex));
            }
        }

        public bool isNewMousePress()
        {
            System.Diagnostics.Debug.WriteLine(CurrentMouseState.LeftButton);
            return (CurrentMouseState.LeftButton == ButtonState.Pressed && LastMouseState.LeftButton == ButtonState.Released);
        }

        /// <summary>
        /// The controllingPlayer parameter specifies which player to read input for. If this is null, it will accept input from any player. 
        /// When the action is detected, the output playerIndex reports which player pressed it.
        /// </summary>
        public bool IsMenuSelect(PlayerIndex? controllingPlayer, out PlayerIndex playerIndex)
        {
            return IsNewKeyPress(Keys.Space, controllingPlayer, out playerIndex) || IsNewKeyPress(Keys.Enter, controllingPlayer, out playerIndex) ||
                   IsNewBtnPress(Buttons.A, controllingPlayer, out playerIndex) || IsNewBtnPress(Buttons.Start, controllingPlayer, out playerIndex);
        }

        /// <summary>
        /// The controllingPlayer parameter specifies which player to read input for. If this is null, it will accept input from any player. 
        /// When the action is detected, the output playerIndex reports which player pressed it.
        /// </summary>
        public bool IsMenuCancel(PlayerIndex? controllingPlayer, out PlayerIndex playerIndex)
        {
            return IsNewKeyPress(Keys.Escape, controllingPlayer, out playerIndex) || IsNewBtnPress(Buttons.B, controllingPlayer, out playerIndex) ||
                   IsNewBtnPress(Buttons.Back, controllingPlayer, out playerIndex);
        }

        /// <summary>
        /// The controllingPlayer parameter specifies which player to read input for. If this is null, it will accept input from any player.
        /// </summary>
        public bool IsMenuUp(PlayerIndex? controllingPlayer)
        {
            PlayerIndex playerIndex;
            return IsNewKeyPress(Keys.Up, controllingPlayer, out playerIndex) ||
                   IsNewKeyPress(Keys.W, controllingPlayer, out playerIndex) ||
                   IsNewBtnPress(Buttons.DPadUp, controllingPlayer, out playerIndex) ||
                   IsNewBtnPress(Buttons.LeftThumbstickUp, controllingPlayer, out playerIndex);
        }

        /// <summary>
        /// The controllingPlayer parameter specifies which player to read input for. If this is null, it will accept input from any player.
        /// </summary>
        public bool IsMenuDown(PlayerIndex? controllingPlayer)
        {
            PlayerIndex playerIndex;
            return IsNewKeyPress(Keys.Down, controllingPlayer, out playerIndex) ||
                   IsNewKeyPress(Keys.S, controllingPlayer, out playerIndex) ||
                   IsNewBtnPress(Buttons.DPadDown, controllingPlayer, out playerIndex) ||
                   IsNewBtnPress(Buttons.LeftThumbstickDown, controllingPlayer, out playerIndex);
        }

        /// <summary>
        /// The controllingPlayer parameter specifies which player to read input for. If this is null, it will accept input from any player.
        /// </summary>
        public bool IsPauseGame(PlayerIndex? controllingPlayer)
        {
            PlayerIndex playerIndex;

            return IsNewKeyPress(Keys.Escape, controllingPlayer, out playerIndex) ||
                   IsNewBtnPress(Buttons.Back, controllingPlayer, out playerIndex) ||
                   IsNewBtnPress(Buttons.Start, controllingPlayer, out playerIndex);
        }

        public bool IsNewLeftAction(PlayerIndex? controllingPlayer)
        {
            PlayerIndex playerIndex;
            return IsNewKeyPress(Keys.A, controllingPlayer, out playerIndex) ||
                   IsNewKeyPress(Keys.Left, controllingPlayer, out playerIndex) ||
                   IsNewBtnPress(Buttons.DPadLeft, controllingPlayer, out playerIndex) ||
                   IsNewBtnPress(Buttons.LeftThumbstickLeft, controllingPlayer, out playerIndex);
        }

        public bool IsNewRightAction(PlayerIndex? controllingPlayer)
        {
            PlayerIndex playerIndex;
            return IsNewKeyPress(Keys.D, controllingPlayer, out playerIndex) ||
                   IsNewKeyPress(Keys.Right, controllingPlayer, out playerIndex) ||
                   IsNewBtnPress(Buttons.DPadRight, controllingPlayer, out playerIndex) ||
                   IsNewBtnPress(Buttons.LeftThumbstickRight, controllingPlayer, out playerIndex);
        }

        public bool IsNewUpAction(PlayerIndex? controllingPlayer)
        {
            return IsMenuUp(controllingPlayer);
        }

        public bool IsNewDownAction(PlayerIndex? controllingPlayer)
        {
            return IsMenuDown(controllingPlayer);
        }

        public bool IsNewLeftAction()
        {
            return IsNewLeftAction(null);
        }

        public bool IsNewRightAction()
        {
            return IsNewRightAction(null);
        }

        public bool IsNewUpAction()
        {
            return IsNewUpAction(null);
        }

        public bool IsNewDownAction()
        {
            return IsNewDownAction(null);
        }

        public bool IsUpAction()
        {
            return CurrentKeyboardState.IsKeyDown(Keys.W) ||
                   CurrentKeyboardState.IsKeyDown(Keys.Up);
        }

        public bool IsDownAction()
        {
            return CurrentKeyboardState.IsKeyDown(Keys.S) ||
                   CurrentKeyboardState.IsKeyDown(Keys.Down);
        }

        public bool IsLeftAction()
        {
            return CurrentKeyboardState.IsKeyDown(Keys.A) ||
                   CurrentKeyboardState.IsKeyDown(Keys.Left);
        }

        public bool IsRightAction()
        {
            return CurrentKeyboardState.IsKeyDown(Keys.D) ||
                   CurrentKeyboardState.IsKeyDown(Keys.Right);
        }

        // 360

        public bool isA(PlayerIndex? controllingPlayer)
        {
            PlayerIndex playerIndex;
            return IsNewBtnPress(Buttons.A, controllingPlayer, out playerIndex);
        }

        public bool isB(PlayerIndex? controllingPlayer)
        {
            PlayerIndex playerIndex;
            return IsNewBtnPress(Buttons.B, controllingPlayer, out playerIndex);
        }

        public bool isX(PlayerIndex? controllingPlayer)
        {
            PlayerIndex playerIndex;
            return IsNewBtnPress(Buttons.X, controllingPlayer, out playerIndex);
        }

        public bool isY(PlayerIndex? controllingPlayer)
        {
            PlayerIndex playerIndex;
            return IsNewBtnPress(Buttons.Y, controllingPlayer, out playerIndex);
        }

        public bool isDpadUp(PlayerIndex? controllingPlayer)
        {
            PlayerIndex playerIndex;
            return IsNewBtnPress(Buttons.DPadUp, controllingPlayer, out playerIndex);
        }

        public bool isDpadDown(PlayerIndex? controllingPlayer)
        {
            PlayerIndex playerIndex;
            return IsNewBtnPress(Buttons.DPadDown, controllingPlayer, out playerIndex);
        }

        public bool isDpadLeft(PlayerIndex? controllingPlayer)
        {
            PlayerIndex playerIndex;
            return IsNewBtnPress(Buttons.DPadLeft, controllingPlayer, out playerIndex);
        }

        public bool isDpadRight(PlayerIndex? controllingPlayer)
        {
            PlayerIndex playerIndex;
            return IsNewBtnPress(Buttons.DPadRight, controllingPlayer, out playerIndex);
        }

    }
}