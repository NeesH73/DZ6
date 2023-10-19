﻿namespace Tymakov7
{
    internal class Builder
    {
        private static int number_building = 1;
        private int id_building;
        private double height;
        private int count_floors;
        private int count_flats;
        private int count_entrance;

        public int IdBuilding
        {
            get { return id_building; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Countfloors
        {
            get { return count_floors; }
            set { count_floors = value; }
        }
        public int CountFlats
        {
            get { return count_flats; }
            set { count_flats = value; }
        }
        public int CountEntrance
        {
            get { return count_entrance; }
            set { count_entrance = value; }
        }
        public double CalculateHeight()
        {
            return (double)height / count_floors;
        }
        public double CalculateCountFlatsinEntrance()
        {
            return (double)count_flats / count_entrance;
        }
        public double CalculateCountFlatsonFloor()
        {
            return ((double)count_flats / count_entrance) / count_floors;
        }
        private void ChangeIdBuilding()
        {
            number_building++;
        }
        public Builder(double height, int count_floors, int count_flats, int count_entrance)
        {
            this.height = height;
            this.count_floors = count_floors;
            this.count_flats = count_flats;
            this.count_entrance = count_entrance;
            id_building = number_building;
            ChangeIdBuilding();
        }
    }
}
