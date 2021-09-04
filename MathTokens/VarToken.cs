﻿using System;

namespace LatexProcessing
{
    public class VarToken : IMathToken
    {
        public MathTokenTypes TokenType { get; protected set; }
        public int? ExpressionPosition { get; }
        public char Name { get; }
        
        public VarToken(char name, int? expressionPosition)
        {
            TokenType = MathTokenTypes.Var;

            Name = name;
            ExpressionPosition = expressionPosition;
        }
        
        /// <summary>
        /// Ignores ExpressionPosition property
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (base.Equals(obj)) return true;
            
            var other = obj as VarToken;
        
            if (other == null) return false;
        
            if (this.Name != other.Name) return false;
            if (this.TokenType != other.TokenType) return false;

            return true;
        }
        
        public override string ToString()
        {
            return $"(Var, '{Name}')";
        }
    }
}