using System.Security.Authentication;

/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then throw an InvalidOperationException with the message "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    // TODO Problem 4 - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveLeft()
    {

        var position = (_currX,_currY); // Minha posição atual


            //A posição atual existe no mapa?
        if (!_mazeMap.ContainsKey(position))
        {
              throw new InvalidOperationException("Can't go that way!");
        }

        bool[] directions = _mazeMap[position]; //cria uma verificação abrindo uma var Bool de verdadeiro ou falso e usa os parametros de _mazemap com as posiçoes
                                                //Agora temos isso aplicado como parametro inicial:
                                                //directions = [true, false, true, false]
                                                //index      =   0      1      2     3

        if (directions[0] == false)
        {
            throw new InvalidOperationException("Can't go that way!");
        }

        var nextposition = (_currX - 1, _currX);

        if (!_mazeMap.ContainsKey(nextposition))
        {
            throw new InvalidOperationException("Can't go that way!");
        }

        _currX -= 1;
        

    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        var position = (_currX,_currY); // Minha posição atual

            //A posição atual existe no mapa?
        if (!_mazeMap.ContainsKey(position))
        {
              throw new InvalidOperationException("Can't go that way!");
        }

        bool[] directions = _mazeMap[position]; //cria uma verificação abrindo um diricionario de verdadeiro ou falso e usa os parametros de _mazemap com as posiçoes
                                                //Agora temos isso aplicado como parametro inicial:
                                                //directions = [true, false, true, false]
                                                //index      =   0      1      2     3

        if (directions[1] == false)
        {
            throw new InvalidOperationException("Can't go that way!");
        }

        var nextposition = (_currX + 1, _currY);

        if (!_mazeMap.ContainsKey(nextposition))
        {
            throw new InvalidOperationException("Can't go that way!");
        }

        _currX += 1;
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        var position = (_currX,_currY); // Minha posição atual
            //A posição atual existe no mapa?
        if (!_mazeMap.ContainsKey(position))
        {
              throw new InvalidOperationException("Can't go that way!");
        }
        bool[] directions = _mazeMap[position]; //cria uma verificação abrindo um diricionario de verdadeiro ou falso e usa os parametros de _mazemap com as posiçoes
                                                //Agora temos isso aplicado como parametro inicial:
                                                //directions = [true, false, true, false]
                                                //index      =   0      1      2     3

        if (directions[2] == false)
        {
            throw new InvalidOperationException("Can't go that way!");
        }

        var nextposition = (_currX, _currY - 1);

        if (!_mazeMap.ContainsKey(nextposition))
        {
            throw new InvalidOperationException("Can't go that way!");
        }

        _currY -= 1;
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        var position = (_currX,_currY); // Minha posição atual

            //A posição atual existe no mapa?
        if (!_mazeMap.ContainsKey(position))
        {
              throw new InvalidOperationException("Can't go that way!");
        }

        bool[] directions = _mazeMap[position]; //cria uma verificação abrindo um diricionario de verdadeiro ou falso e usa os parametros de _mazemap com as posiçoes
                                                //Agora temos isso aplicado como parametro inicial:
                                                //directions = [true, false, true, false]
                                                //index      =   0      1      2     3

        if (directions[3] == false)
        {
            throw new InvalidOperationException("Can't go that way!");
        }

        var nextposition = (_currX, _currY + 1);

        if (!_mazeMap.ContainsKey(nextposition))
        {
            throw new InvalidOperationException("Can't go that way!");
        }

        _currY += 1;
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}