using System;
namespace Assignment_1
{
	public class Spaceship
	{
		public string Name { get; }

		public int Size { get; }

		private int _remainingStorage;

		private Stack<Cargo> _storage = new Stack<Cargo>();

		public Spaceship(string name, int size)
		{
			Name = name;

			Size = size;

            _remainingStorage = size;
        }

		public bool AddCargo(Cargo item)
		{
			var usedStorage = 0;

			foreach (var cargoItem in _storage)
			{
				usedStorage += cargoItem.Size;
			}

			if (usedStorage + item.Size >= Size)
			{
				return false;
			}

			_storage.Push(item);
            _remainingStorage -= item.Size;

            return true;
		}

		public Cargo RemoveCargo()
		{
			if (_storage.Count == 0)
			{
				return null;
			}

			var removedCargoItem = _storage.Pop();

			_remainingStorage += removedCargoItem.Size;

			return removedCargoItem;
		}

		public void ListCargo()
		{
			if (_storage.Count == 0)
			{
                Console.WriteLine("Cargo storage is empty.");
            }
			foreach (var cargoItem in _storage)
			{
				Console.WriteLine($"* {cargoItem.Description}");
			}
		}

		public bool MoveCargoTo(Spaceship spaceship)
		{
            Cargo cargo;
            while ((cargo = RemoveCargo()) != null)
            {
                if (spaceship.AddCargo(cargo))
                {
                    continue;
                }

                AddCargo(cargo);
                return false;
            }

            return true;
        }
    }
}

