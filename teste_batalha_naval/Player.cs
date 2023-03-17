using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_batalha_naval
{
    internal class Player
    {
        public int _life { get; set; }
        public Submarine _submarine { get; set; }
        public Destroyer _destroyer { get; set; }
        public AircraftCarrier _aircraftCarrier{ get; set; }
        public Board _board { get; set; }
        public string Name { get; set; }

        public Player()
        {
            this._life = 9;
            this._submarine = new Submarine();
            this._destroyer = new Destroyer();
            this._aircraftCarrier = new AircraftCarrier();
            this._board = new Board();
        }

        public void TakeLife()
        {
            this._life--;
        }

        public int Shot(int row, int col)
        {
            return this._board.VerifyShot(row, col);

            /*for(int i = 0; i < this._submarine._positions.GetLength(0); i++)
            {
                if (this._submarine._positions[i, 0] == row)
                {
                    if (this._submarine._positions[i, 1] == col)
                    {
                        TakeLife();
                        return true;
                    }
                }
            }

            for (int i = 0; i < this._destroyer._positions.GetLength(0); i++)
            {
                if (this._destroyer._positions[i, 0] == row)
                {
                    if (this._destroyer._positions[i, 1] == col)
                    {
                        TakeLife();
                        return true;
                    }
                }
            }

            for (int i = 0; i < this._aircraftCarrier._positions.GetLength(0); i++)
            {
                if (this._aircraftCarrier._positions[i, 0] == row)
                {
                    if (this._aircraftCarrier._positions[i, 1] == col)
                    {
                        TakeLife();
                        return true;
                    }
                }
            }*/
        }

        public int InsertShip(int[] positions, Ship ship, int orientation)
        {
            int row = positions[0];
            int col = positions[1];
            string aux;

            if(orientation == 1)
            {
                aux = "horizontal";
            }
            else
            {
                aux = "vertical";
            }

            int operation = _board.VerifyPosition(row, col, ship, aux);

            if (operation != 0)
            {
                _board.InsertBoard(row, col, operation, aux);
                //funcao
            }
            else
            {
                Console.WriteLine("Nao pode ocupar esta posicao");
            }
            return operation;
        }
    }
}
